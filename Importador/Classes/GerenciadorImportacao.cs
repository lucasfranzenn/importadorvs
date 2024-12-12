using Dapper;
using DevExpress.XtraEditors;
using Importador.Conexao;
using Importador.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using static Importador.Classes.Constantes;
using static Importador.Classes.Utils;

namespace Importador.Classes
{
    public static class GerenciadorImportacao
    {
        public static int GetQtdRegistros(string sql)
        {
            IDbCommand count = ConexaoManager.instancia.GetConexaoImportacao().CriarComando();
            count.CommandText = $"select count(*) from ({sql.Trim().TrimEnd(';')}) as qtd";

            return Convert.ToInt32(count.ExecuteScalar());
        }

        public static void Importar(string sql, ProgressBarControl pbImportacao, string tabela, List<CheckEdit> parametros)
        {
            StringBuilder sbSql = new();
            IDbCommand sqlQuery = ConexaoManager.instancia.GetConexaoImportacao().CriarComando();
            int qtdRegistros = GetQtdRegistros(sql);
            int registroAtual = 1;
            object value = null;
            IDbDataParameter parameter = null;
            var ListaFuncoesValidadoras = Mapeamento.FuncoesDuranteImportacaoPorParametro.Keys.Where(k => parametros.Select(p => p.Name).Contains(k)).ToList();

            sqlQuery.CommandText = sql;

            pbImportacao.Invoke((MethodInvoker)(() =>
            {
                pbImportacao.EditValue = 0;
                pbImportacao.Properties.Maximum = qtdRegistros;
            }));
            
            //Limpa tabelas
            if (parametros.Exists((p) => string.Equals(p.Name, "cbExcluirRegistros", StringComparison.OrdinalIgnoreCase) && p.Checked))
                if (Mapeamento.TabelasTruncatePorTabela.TryGetValue(tabela, out _))
                    LimpaTabelas(Mapeamento.TabelasTruncatePorTabela[tabela]);
                else
                    LimpaTabelas(new List<string> { tabela });

            //Rodar parametros pré-importação
            var list = Mapeamento.FuncoesPreImportacaoPorParametro.Keys.Where(k => parametros.Select(p => p.Name).Contains(k)).ToList();
            list.ForEach(p => Mapeamento.FuncoesPreImportacaoPorParametro[p](p));

            using IDataReader reader = sqlQuery.ExecuteReader();
            int qtdColunas = reader.FieldCount;
            string[] nomeColunas = new string[qtdColunas];
            int[] tamColunas = new int[qtdColunas];
            string[] datatypeColunas = new string[qtdColunas];

            for (int i = 0; i < qtdColunas; i++)
            {
                nomeColunas[i] = reader.GetName(i).ToLower();
                tamColunas[i] = GetTamanhoColuna(nomeColunas[i], tabela);
                datatypeColunas[i] = GetDataType(nomeColunas[i], tabela);
            }

            sbSql.Clear();
            sbSql.Append($"INSERT INTO {tabela} (");
            sbSql.Append(string.Join(", ", nomeColunas));
            sbSql.Append(") VALUES (");
            sbSql.Append(string.Join(", ", nomeColunas.Select(col => $"@{col}")));
            sbSql.Append(");");

            pbImportacao.Invoke((MethodInvoker)(() =>
            {
                pbImportacao.CustomDisplayText += (sender, args) =>
                {
                    args.DisplayText = $"{registroAtual} de {qtdRegistros} registros";
                };
            }));

            string sqlInsert = sbSql.ToString();

            using (IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando())
            {
                while (reader.Read())
                {
                    cmd.CommandText = sqlInsert;
                    cmd.Parameters.Clear();

                    #region Funcoes Validadoras durante a importação (Validar CPF/CGC, CódBarras, etc)
                    if (ListaFuncoesValidadoras.Count != 0)
                    {
                        foreach (var func in ListaFuncoesValidadoras)
                        {
                            if (Mapeamento.FuncoesDuranteImportacaoPorParametro[func](reader)) goto ProximoItem;
                        }
                    }
                    #endregion

                    for (int i = 0; i < qtdColunas; i++)
                    {
                        value = reader.GetValue(i);

                        if (Mapeamento.FuncoesFormatadorasPorColuna.ContainsKey(nomeColunas[i])) Mapeamento.FuncoesFormatadorasPorColuna[nomeColunas[i]].ForEach(func => value = func(value));
                        parameter = cmd.CreateParameter();
                        parameter.ParameterName = $"@{nomeColunas[i]}";

                        parameter.Value = Utils.CastDataType(datatypeColunas[i], value, tamColunas[i]);

                        cmd.Parameters.Add(parameter);

                        value = null;
                    }
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = null;

                ProximoItem:;
                    //Incrementa a progressbar e atualiza o seu texto
                    pbImportacao.Invoke((MethodInvoker)(() => {
                        pbImportacao.PerformStep();
                        pbImportacao.Update();
                    }));

                    registroAtual = Convert.ToInt32(pbImportacao.EditValue);
                }

            }
            pbImportacao.Invoke((MethodInvoker)(() =>
            {
                pbImportacao.CustomDisplayText += (sender, args) =>
                {
                    args.DisplayText = $"Todos os {qtdRegistros} registros foram importados. Rodando updates para ajustes.";
                };
            }));

            UpdatesPorTabela(tabela);

            //Rodar parametros pós-importação
            var funcoesPosImportacao = Mapeamento.FuncoesPosImportacaoPorParametro.Keys.Where(k => parametros.Select(p => p.Name).Contains(k)).ToList();
            funcoesPosImportacao.ForEach(p => Mapeamento.FuncoesPosImportacaoPorParametro[p](tabela));
        }

        private static string GetDataType(string coluna, string tabela)
        {
            IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
            cmd.CommandText = $"SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tabela}' AND COLUMN_NAME = '{coluna}' AND TABLE_SCHEMA = '{GetImportacao(Enums.Sistema.MyCommerce).Banco}'";
            string retorno = cmd.ExecuteScalar().ToString();

            return retorno;
        }

        private static void UpdatesPorTabela(string tabela)
        {
            List<string> updates;
            IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
            if (Mapeamento.UpdatesPorTabela.TryGetValue(tabela, out updates))
            {
                if (tabela == "produtos")
                {
                    if (Configuracoes.Default.RegimeEmpresa == 0)
                    {
                        updates.Add("update produtos  set cst_simples = '0500' where cst_simples is null");
                        updates.Add("update produtos p inner join situacaotributaria st on st.codigo = p.cst_simples set cst_simples_texto = left(st.descricao,45)");
                        updates.Add("update produtos set cst_pis_simples = cst_pis, cst_cofins_simples = cst_cofins, cst_ipi_simples = cst_ipi, aliq_pis_simples = aliq_pis, aliq_cofins_simples = aliq_cofins");
                    }
                    else
                    {
                        updates.Add("update produtos set codigocf = '000' where codigocf is null");
                        updates.Add("update produtos p inner join situacaotributaria st on st.codigo = p.codigocf set situacaotributaria= left(st.descricao,45)");
                    }
                }

                foreach (string query in updates)
                {
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static int GetTamanhoColuna(string coluna, string tabela)
        {
            IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
            cmd.CommandText = $"SELECT CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tabela}' AND COLUMN_NAME = '{coluna}' AND TABLE_SCHEMA = '{GetImportacao(Enums.Sistema.MyCommerce).Banco}'";
            int retorno = int.TryParse(cmd.ExecuteScalar().ToString(), out retorno) ? retorno : 1;

            return retorno;
        }

        public static DataTable PreencheGrid(string coluna)
        {
            IDbCommand cmd = ConexaoManager.instancia.GetConexaoImportacao().CriarComando();
            cmd.CommandText = ConexaoManager.instancia.GetProcurarColunaQuery(coluna);

            using IDataReader reader = cmd.ExecuteReader();
            DataTable dt = new();
            dt.Load(reader, LoadOption.OverwriteChanges);
            return dt;
        }

        private static void LimpaTabelas(List<string> tabelas)
        {
            foreach (string tabela in tabelas)
            {
                IDbCommand truncate = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
                truncate.CommandText = $"truncate table {tabela};";
                truncate.ExecuteNonQuery();
            }
        }

        internal static object CriarConsumidorFinal(object _)
        {
            ConexaoManager.instancia.GetConexaoMyCommerce()
                .Execute("INSERT INTO clientes SET CODIGO = 1, tipo = 'c', RazaoSocial = 'CONSUMIDOR',  NomeFantasia  = 'CONSUMIDOR', Endereco  = '.', Bairro  = 'CENTRO', Cidade  = 'QUEDAS DO IGUAÇU', UF  = 'PR', cep  = '85.460-000', codigocidadeibge = 4120903 , numero = '1', FisicaJuridica = 'F'");

            return true;
        }

        internal static bool ValidarExistenciaDocumento(IDataReader reader)
        {
            string cpf = Formatadores.FormataCPF(reader["cpf"]).ToString().Trim();
            string cnpj = Formatadores.FormataCNPJ(reader["cnpj"]).ToString().Trim();

            bool existe = ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar($"SELECT codigo FROM CLIENTES WHERE CPF = '{cpf}' or CNPJ = '{cnpj}'") is not null;

            return existe;
        }

        internal static object CriarUnidades(object _)
        {
            string sql = "SELECT UNVENDA, IF(UNVENDA = 'UN', 1, 0) AS padrao FROM PRODUTOS WHERE UNVENDA IS NOT NULL GROUP BY unvenda";

            IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
            cmd.CommandText = sql;
            IDataReader reader = cmd.ExecuteReader();
            List<(string unvenda, int padrao)> result = new List<(string unvenda, int padrao)>();

            while (reader.Read())
            {
                result.Add((reader["unvenda"].ToString(), Convert.ToInt32(reader["padrao"])));
            }
            reader.Close();

            foreach (var r in result)
            {
                ConexaoManager.instancia.GetConexaoMyCommerce().Execute($"INSERT INTO unidades (und, descricao, padrao) VALUES ('{r.unvenda}', '{r.unvenda}', {r.padrao})");
            }

            return true;
        }

        internal static bool ValidarExistenciaCodBarras(IDataReader reader)
        {
            string codbar = reader["codigobarras"].ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(codbar)) return false;

            string sql = $"SELECT codigoproduto, barcode from (select codigo as codigoproduto, codigobarras as barcode from produtos where codigobarras is not null union all select codigoproduto, barcode from produtosbarcode) as tab where barcode = '{codbar}'";

            return (ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar(sql) is not null);
        }

        internal static object CriarTabelaPreco(object _)
        {
            var cmdSelect = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
            var cmdInsert = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
            cmdSelect.CommandText = "select concat(sum(padrao), ';', sum(if (TP_preco = 'G', 1,0))) from tabelas";

            object x = cmdSelect.ExecuteScalar();

            if (string.IsNullOrEmpty(x.ToString())) x = 0;

            if (Convert.ToInt32(x.ToString().Split(';')[0]) >= 1)
            {
                cmdInsert.CommandText = "INSERT INTO tabelas (Descricao,Percentual,TIPO,Considera_Promocao,TP_Preco,Padrao,UF,Optante,Empresas,DescMaximo,TipoAtu_Individual,TaxaAtu_Individual,Atualiza_Individual,OrdemFutura,Atu_Individual_Empresa,PComissao,Recalcula_Promocao,SomaIPI,ExibeTab,DescontaSt,Cancelada,Calc_Simples_campoDIF,DescontoNF,PercentualServico,UltimaAlteracaoCad,DescontoPadrao,TpComissao,TaxaDesc_Individual,RegraBS_CalculoST,NaoUsaDescontoImposto,IgnoraMultiplo,ExigeCadastroCliente,PadraoMeuERP,UsuarioExclusao,MotivoExclusao,DataExclusao) VALUES ('VALOR PRODUTO',0.0,'V',0,'G',1,'','N',NULL,NULL,'',0.0,0,0,'',NULL,0,'N',0,0,NULL,0,NULL,NULL,'2024-01-12 09:57:29',0.0,'G',0.0,0,0,0,0,0,NULL,NULL,NULL);";
            }
            else
            {
                cmdInsert.CommandText = "INSERT INTO tabelas (Descricao,Percentual,TIPO,Considera_Promocao,TP_Preco,Padrao,UF,Optante,Empresas,DescMaximo,TipoAtu_Individual,TaxaAtu_Individual,Atualiza_Individual,OrdemFutura,Atu_Individual_Empresa,PComissao,Recalcula_Promocao,SomaIPI,ExibeTab,DescontaSt,Cancelada,Calc_Simples_campoDIF,DescontoNF,PercentualServico,UltimaAlteracaoCad,DescontoPadrao,TpComissao,TaxaDesc_Individual,RegraBS_CalculoST,NaoUsaDescontoImposto,IgnoraMultiplo,ExigeCadastroCliente,PadraoMeuERP,UsuarioExclusao,MotivoExclusao,DataExclusao) VALUES ('VALOR PRODUTO',0.0,'V',0,'G',1,'','N',NULL,NULL,'',0.0,0,0,'',NULL,0,'N',0,0,NULL,0,NULL,NULL,'2024-01-12 09:57:29',0.0,'G',0.0,0,0,0,0,0,NULL,NULL,NULL);";
            }

            cmdInsert.ExecuteNonQuery();

            return true;
        }

        internal static object AlterarTabelaClientes(object arg)
        {
            ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar("ALTER TABLE `clientes` CHANGE COLUMN `Usuario` `Usuario` VARCHAR(45) NULL DEFAULT NULL COLLATE 'latin1_swedish_ci', CHANGE COLUMN `Terminal` `Terminal` VARCHAR(45) NULL DEFAULT NULL COLLATE 'latin1_swedish_ci'");
            return true;
        }

        internal static object VincularCliForPorCodigoImpDados(object arg)
        {
            switch (arg)
            {
                case "produtosfornecedor":
                    ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar($"UPDATE {arg} join CLIENTES on {arg}.idFornecedor = clientes.contato and clientes.tipo = 'F' SET {arg}.idFornecedor = clientes.codigo");
                    break;
                case "contasapagar":
                    ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar($"UPDATE {arg} join CLIENTES on {arg}.RazaoSocial = clientes.contato and clientes.tipo = 'F' SET {arg}.Codigo = clientes.codigo, {arg}.razaosocial = clientes.razaosocial");
                    break;
                default:
                    ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar($"UPDATE {arg} join CLIENTES on {arg}.RazaoSocial = clientes.contato SET {arg}.Codigo = clientes.codigo, {arg}.razaosocial = clientes.razaosocial");
                    break;
            }

            return true;
        }

        internal static bool ImportarEstoque(IDataReader reader)
        {
            var cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();

            cmd.CommandText = $"INSERT INTO acertoestoque set data = curdate(), hora = curtime(), codigoproduto = {reader["codigoproduto"]}, qtde = @Estoque, Tipo = 'E'" +
                $", Empresa = {reader["empresa"]}, valor = 0, Usuario = 'MASTER', terminal = 'SERVIDOR', OBS= 'TRANSF. ESTOQUE'";

            var parametro = cmd.CreateParameter();
            parametro.ParameterName = "@Estoque";
            parametro.Value = reader["estoque"];

            cmd.Parameters.Add(parametro);
            cmd.ExecuteNonQuery();

            return false;
        }

        internal static object VerificarDuplicidade(object arg)
        {
            int qtdDivergencias = Convert.ToInt32(ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar("select group_concat(distinct empresa) as empresas, count(codigoproduto) as qtdProdutos from (select count(codigoproduto) as qt, CodigoProduto, Empresa from produtosestoque group by CodigoProduto, empresa having qt > 1) as tab"));

            if (qtdDivergencias != 0)
                XtraMessageBox.Show($"Existe {qtdDivergencias} produto(s) que estão com estoque duplicado!\nVerifique antes de continuar.", "..::Importador::..");

            return null;

        }

        internal static bool VincularProdPorCodigoImpDados(IDataReader reader)
        {
            var cmdSelect = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
            cmdSelect.CommandText = $"select codigo from produtos where produtos.CodigoImportacaoDados = '{reader["codigoproduto"].ToString()}'";
            var codigoProduto = cmdSelect.ExecuteScalar();

            if (codigoProduto is null) return true;

            var cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
            var parametro = cmd.CreateParameter();

            parametro.ParameterName = "@Estoque";
            parametro.Value = reader["estoque"];
            cmd.Parameters.Add(parametro);

            cmd.CommandText = $"INSERT INTO produtosestoque set codigoproduto = {codigoProduto}, Estoque = @Estoque, Empresa = {Convert.ToInt32(reader["empresa"])}, DataUltimaMov = curdate(), USUARIO = 'MASTER'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = $"INSERT INTO acertoestoque set data = curdate(), hora = curtime(), codigoproduto = {codigoProduto}, qtde = @Estoque, Tipo = 'E'" +
                $", Empresa = {reader["empresa"]}, valor = 0, Usuario = 'MASTER', terminal = 'SERVIDOR', OBS= 'TRANSF. ESTOQUE'";
            cmd.ExecuteNonQuery();

            return true;
        }

        internal static string VerificarSQL(string sql)
        {
            IDbCommand cmdSql = ConexaoManager.instancia.GetConexaoImportacao().CriarComando();
            cmdSql.CommandText = $"{sql}";

            try
            {
                cmdSql.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return null;
        }

        internal static bool ImportarCodBarrasAdicionais(IDataReader reader)
        {
            string codbar = reader["barcode"].ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(codbar)) return true;

            int codigoProduto = Convert.ToInt32(reader["codigoproduto"]);

            string sql = $"select codigobarras from produtos where codigo = {codigoProduto} and codigobarras = '{codbar}'";

            return (ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar(sql) is not null);
        }

        internal static object AtualizarCodBarras(object arg)
        {
            ConexaoManager.instancia.GetConexaoMyCommerce()
                .ExecuteScalar("UPDATE PRODUTOS join (select min(sequencia), codigoproduto, barcode from produtosbarcode group by codigoproduto) bc on produtos.codigo = bc.codigoproduto" +
                " set produtos.codigobarras = bc.barcode where produtos.codigobarras is null or produtos.codigobarras = ''");

            return null;
        }

        internal static bool VincularCodBarPorCodigoImpDados(IDataReader reader)
        {
            string codbar = reader["barcode"].ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(codbar)) return true;

            var codigoProduto = ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar($"select codigo from produtos where CodigoImportacaoDados = '{reader["codigoproduto"].ToString()}'") ?? "null";
            var fracionario = reader["fracionario"] ?? 1;
            var gradeLinha = reader["grade_linha"] is DBNull ? "null" : reader["grade_linha"];
            var gradeColuna = reader["grade_coluna"] is DBNull ? "null" : reader["grade_coluna"];
            var idGrade = reader["idgrade"] is DBNull ? "null" : reader["idgrade"];

            string sql = $"select codigobarras from produtos where codigo = {codigoProduto} and codigobarras = '{codbar}'";

            if (!string.Equals(codigoProduto.ToString(), "null", StringComparison.OrdinalIgnoreCase) && ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar(sql) is null)
            {
                string sqlInsert = $"INSERT INTO produtosbarcode SET codigoproduto = {codigoProduto}, barcode = '{codbar}', fracionario = {fracionario}, " +
                    $"grade_linha = {gradeLinha}, grade_coluna = {gradeColuna}, idgrade={idGrade}" ;
                ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar(sqlInsert);
            }

            return true;
        }
    }
}
