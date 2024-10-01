using Dapper;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.OpenDocument;
using Importador.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Importador.Classes.Constantes;
using static Importador.Classes.Utils;

namespace Importador.Classes
{
    public static class GerenciadorImportacao
    {
        public static int GetQtdRegistros(string sql)
        {
            IDbCommand count = ConexaoManager.instancia.GetConexaoImportacao().CreateCommand();
            count.CommandText = $"select count(*) from ({sql.TrimEnd(';')}) as qtd";

            return Convert.ToInt32(count.ExecuteScalar());
        }

        public static void Importar(string sql, ref ProgressBarControl pbImportacao, Enums.TabelaMyCommerce tabela, List<CheckEdit> parametros)
        {
            StringBuilder sqlInsert = new();
            IDbCommand sqlQuery = ConexaoManager.instancia.GetConexaoImportacao().CreateCommand();
            int qtdRegistros = GetQtdRegistros(sql);

            sqlQuery.CommandText = sql;

            pbImportacao.EditValue = 0;
            pbImportacao.Properties.Maximum = qtdRegistros;

            //Limpa tabelas
            if (parametros.Exists((p) => string.Equals(p.Name, "cbExcluirRegistros") && p.Checked)) LimpaTabelas(Mapeamento.TabelasTruncatePorTabela[tabela.ToString()]);

            //Rodar parametros pré-importação
            var list = Mapeamento.FuncoesPreImportacaoPorParametro.Keys.Where(k => parametros.Select(p => p.Name).Contains(k)).ToList();
            list.ForEach(p => Mapeamento.FuncoesPreImportacaoPorParametro[p](p));

            using IDataReader reader = sqlQuery.ExecuteReader();
            int qtdColunas = reader.FieldCount;
            string[] nomeColunas = new string[qtdColunas];
            int[] tamColunas = new int[qtdColunas];

            for (int i = 0; i < qtdColunas; i++)
            {
                nomeColunas[i] = reader.GetName(i).ToLower();
                tamColunas[i] = GetTamanhoColuna(nomeColunas[i], tabela.ToString());
            }

            sqlInsert.Clear();
            sqlInsert.Append($"INSERT INTO {tabela.ToString()} (");
            sqlInsert.Append(string.Join(", ", nomeColunas));
            sqlInsert.Append(") VALUES (");
            sqlInsert.Append(string.Join(", ", nomeColunas.Select(col => $"@{col}")));
            sqlInsert.Append(");");

            while (reader.Read())
            {
                using (IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CreateCommand())
                {
                    cmd.CommandText = sqlInsert.ToString();
                    cmd.Parameters.Clear();

                    #region Funcoes Validadoras durante a importação (Validar CPF/CGC, CódBarras, etc)
                    List<bool> listaRetornos = new();

                    var funcoes = Mapeamento.FuncoesDuranteImportacaoPorParametro.Keys.Where(k => parametros.Select(p => p.Name).Contains(k)).ToList();
                    funcoes.ForEach(func =>
                    {
                        listaRetornos.Add(Mapeamento.FuncoesDuranteImportacaoPorParametro[func](reader));
                    });

                    if (listaRetornos.Any(ret => ret == true)) goto ProximoItem;
                    #endregion

                    for (int i = 0; i < qtdColunas; i++)
                    {
                        object value = reader.GetValue(i);                        

                        if (Mapeamento.FuncoesFormatadorasPorColuna.ContainsKey(nomeColunas[i])) Mapeamento.FuncoesFormatadorasPorColuna[nomeColunas[i]].ForEach(func => value = func(value));

                        IDbDataParameter parameter = cmd.CreateParameter();
                        parameter.ParameterName = $"@{nomeColunas[i]}";

                        if (value is DBNull)
                        {
                            parameter.Value = DBNull.Value;
                        }
                        else if(value is string)
                        {
                            parameter.Value =  value.ToString().Length <= tamColunas[i] ? value.ToString() : value.ToString().Substring(0, tamColunas[i]);
                            parameter.Value = string.IsNullOrEmpty(value.ToString()) ? DBNull.Value : parameter.Value;
                        }
                        else
                        {
                            parameter.Value = value;
                        }
                        cmd.Parameters.Add(parameter);
                    }

                    cmd.ExecuteNonQuery();

                }

                ProximoItem:;
                //Incrementa a progressbar e atualiza o seu texto
                int registroAtual = Convert.ToInt32(pbImportacao.EditValue) + 1;
                pbImportacao.PerformStep();
                pbImportacao.Update();
                pbImportacao.CustomDisplayText += (sender, args) =>
                {
                    args.DisplayText = $"{registroAtual} de {qtdRegistros} registros";
                };
            }
            pbImportacao.CustomDisplayText += (sender, args) =>
            {
                args.DisplayText = $"Todos os {qtdRegistros} registros foram importados. Rodando updates para ajustes.";
            };
            UpdatesPorTabela(tabela);
        }

        private static void UpdatesPorTabela(Enums.TabelaMyCommerce tabela)
        {
            switch (tabela)
            {
                case Enums.TabelaMyCommerce.clientes:
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("UPDATE CLIENTES SET STATUS = 'ATIVA' WHERE STATUS = '' OR STATUS IS NULL");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("UPDATE CLIENTES SET STAT = 'f' WHERE STAT = '' OR STAT IS NULL");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("UPDATE CLIENTES SET TIPO = 'C' WHERE TIPO = '' OR TIPO IS NULL");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("UPDATE CLIENTES SET ATIVO = -1 WHERE ATIVO = 0 OR ATIVO IS NULL");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("UPDATE CLIENTES SET RAZAOSOCIAL = NOMEFANTASIA WHERE RAZAOSOCIAL = ''");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("UPDATE clientes set FisicaJuridica ='F', ConsFinal =1 WHERE cpf  is not null and FisicaJuridica is null");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("UPDATE clientes set FisicaJuridica ='J' WHERE cnpj  is not null and FisicaJuridica is null");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("UPDATE clientes SET datacadastro =  CURDATE() ; ");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("ALTER TABLE `clientes` CHANGE COLUMN `Usuario` `Usuario` VARCHAR(45) NULL COLLATE 'latin1_swedish_ci', CHANGE COLUMN `Terminal` `Terminal` VARCHAR(45) NULL COLLATE 'latin1_swedish_ci';");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("UPDATE CLIENTES SET USUARIO = 'MASTER', Terminal='SERVER';");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("UPDATE clientes cl LEFT JOIN cidades ci ON cl.Cidade = ci.Cidade AND cl.UF = ci.UF SET cl.CodigoCidadeIbge = ci.Codigo WHERE cl.CodigoCidadeIbge IS NULL;");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("update clientes set consfinal = 1, Contribuinte_Icms = 0 where fisicajuridica = 'F';");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("update clientes set consfinal = 0, Contribuinte_Icms = 1 where fisicajuridica = 'J' and ie != 'ISENTO';");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("update clientes set consfinal = 1, Contribuinte_Icms = 0 where fisicajuridica = 'J' and ie = 'ISENTO';");
                    ConexaoManager.instancia.GetConexaoMyCommerce().Execute("update clientes set consfinal = 1, Contribuinte_Icms = 0 where consfinal IS NULL;");
                    break;
                case Enums.TabelaMyCommerce.produtos:
                    break;
                default:
                    break;
            }
        }

        private static int GetTamanhoColuna(string coluna, string tabela)
        {
            IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CreateCommand();
            cmd.CommandText = $"SELECT CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tabela}' AND COLUMN_NAME = '{coluna}' AND TABLE_SCHEMA = '{GetImportacao(Enums.Sistema.MyCommerce).Banco}'";
            int retorno = int.TryParse(cmd.ExecuteScalar().ToString(), out retorno) ? retorno : 1;

            return retorno;
        }

        public static DataTable PreencheGrid(string coluna)
        {
            IDbCommand cmd = ConexaoManager.instancia.GetConexaoImportacao().CreateCommand();
            cmd.CommandText = ConexaoManager.instancia.GetProcurarColunaQuery(coluna);

            using IDataReader reader = cmd.ExecuteReader();
                DataTable dt = new();
                dt.Load(reader);
            return dt;
        }

        private static void LimpaTabelas(List<string> tabelas)
        {
           foreach (string tabela in tabelas)
            {
                IDbCommand truncate = ConexaoManager.instancia.GetConexaoMyCommerce().CreateCommand();
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
            

            //if (existe)
            //{
            //    System.Windows.Forms.MessageBox.Show($"{reader["razaosocial"].ToString()} => ({cpf} - {cnpj})");
            //}

            return existe;
        }
    }
}
