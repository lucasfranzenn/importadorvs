using Dapper;
using DevExpress.XtraEditors;
using FuzzySharp;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.Properties;
using Importador.UserControls.Importacao;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Importador.Classes.Constantes;

namespace Importador.Classes
{
    internal class Centralizador
    {
        private int pontuacao_atual =0;
        private int pontuacao_maxima = 0;
        private int taxa_minima = 60;
        IDbConnection conexao_auxiliar = null;

        public Centralizador()
        {
            conexao_auxiliar = new MariaDbConnection().CriarConexao(Utils.GetImportacao(Enums.Sistema.MyCommerce));
        }

        public Centralizador(int taxa_minima)
        {
            this.taxa_minima = taxa_minima;
            conexao_auxiliar = new MariaDbConnection().CriarConexao(Utils.GetImportacao(Enums.Sistema.MyCommerce));
        }

        public void AjustarClientes(ProgressBarControl pbImportacao)
        {
            var lista_clientes_excluidos = new List<string[]>();
            var lista_clientes_alterados = new List<string[]>();
            int quantidade_execucoes;

            var reader_comando_original = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
            conexao_auxiliar.Open();

            var reader_comando_duplicado = conexao_auxiliar.CriarComando();

            pbImportacao.Invoke((MethodInvoker)(() =>
            {
                pbImportacao.Properties.Maximum = 2;
                pbImportacao.EditValue = 0;
            }));

            IDataReader reader_clientes_original;
            IDataReader reader_clientes_duplicados;

            #region Variaveis Cliente Original
            string razao_cliente_original = null;
            string cgc_cliente_original = null;
            object codigo_cliente_original = null;
            #endregion

            #region Variaveis Cliente Duplicado
            string razao_cliente_duplicado = null;
            object codigo_cliente_duplicado = null;
            #endregion

            foreach (var cgc in new string[] {"cpf", "cnpj" })
            {
                quantidade_execucoes = Convert.ToInt32(ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar($"select count(*) from clientes where {cgc} <> '000000000-00' and {cgc} <> '00.000.000/0000-00' group by {cgc} having count(*)>1 order by count(*) desc limit 1"));
                reader_comando_original.CommandText = $"select min(CODIGO) as codigo, RazaoSocial, {cgc} from clientes where {cgc} in (select {cgc} from clientes where {cgc} <> '000000000-00' and {cgc} <> '00.000.000/0000-00' group by {cgc} having count(*)>1) group by {cgc} order by empresacadastro asc, DataAlteracao desc, codigo asc";

                for (int i=0; i < quantidade_execucoes; i++)
                {
                    reader_clientes_original = reader_comando_original.ExecuteReader();

                    while (reader_clientes_original.Read())
                    {
                        pontuacao_maxima = 0;
                        codigo_cliente_original = reader_clientes_original[0];
                        razao_cliente_original = reader_clientes_original[1].ToString();
                        cgc_cliente_original = reader_clientes_original[2].ToString();

                        reader_comando_duplicado.CommandText = $"select codigo, razaosocial from clientes where {cgc} = '{cgc_cliente_original}' and codigo <> {codigo_cliente_original}";
                        reader_clientes_duplicados = reader_comando_duplicado.ExecuteReader();

                        while (reader_clientes_duplicados.Read())
                        {
                            pontuacao_atual = Fuzz.Ratio(razao_cliente_original, reader_clientes_duplicados[1].ToString());

                            if (pontuacao_atual > pontuacao_maxima)
                            {
                                pontuacao_maxima = pontuacao_atual;
                                codigo_cliente_duplicado = Convert.ToInt32(reader_clientes_duplicados[0]);
                                razao_cliente_duplicado = reader_clientes_duplicados[1].ToString();
                            }
                        }
                        reader_clientes_duplicados.Close();

                        if (pontuacao_maxima > taxa_minima)
                        {
                            conexao_auxiliar.ExecuteScalar($"UPDATE contasareceber SET codigo={codigo_cliente_original}, razaosocial = '{Formatadores.FormataAspas(razao_cliente_original)}' where codigo = {codigo_cliente_duplicado}");
                            conexao_auxiliar.ExecuteScalar($"UPDATE contasapagar SET codigo={codigo_cliente_original}, razaosocial = '{Formatadores.FormataAspas(razao_cliente_original)}' where codigo = {codigo_cliente_duplicado}");
                            conexao_auxiliar.ExecuteScalar($"UPDATE clientes set ativo=0, userid='AJUSTE', ReferenciaContato1='{cgc_cliente_original}', {cgc}=null, TerminalExclusao='IMPORTACAO',MotivoExclusao='CLIENTE DUPLICADO, FOI MANTIDO O CLIENTE CÓDIGO: {codigo_cliente_original}',DataHoraExclusao = now(), EmpresaExclusao = EmpresaCadastro where CODIGO={codigo_cliente_duplicado}");
                            lista_clientes_excluidos.Add(new string[] { codigo_cliente_duplicado.ToString(), razao_cliente_duplicado, cgc_cliente_original, codigo_cliente_original.ToString(), razao_cliente_original });
                        }
                        else if (pontuacao_maxima != 0)
                        {
                            conexao_auxiliar.ExecuteScalar($"UPDATE CLIENTES SET ReferenciaContato1 = {cgc} where codigo = {codigo_cliente_duplicado}");
                            conexao_auxiliar.ExecuteScalar($"UPDATE CLIENTES SET {cgc} = null where codigo = {codigo_cliente_duplicado}");
                            lista_clientes_alterados.Add(new string[] { codigo_cliente_duplicado.ToString(), razao_cliente_duplicado.ToString(), cgc_cliente_original });
                        }
                    }
                    reader_clientes_original.Close();
                }
                pbImportacao.Invoke((MethodInvoker)(() => pbImportacao.PerformStep()));
            }


            conexao_auxiliar.Close();
            Utils.CriarTXT($"Centralizador de dados\nImplantação{Configuracoes.Default.CodigoImplantacao}\n\n" + Utils.ExportRegToText(new string[] { "Codigo Cliente Excluido", "Razao Cliente Excluido", "CPF", "Codigo Cliente Mantido", "Razao Cliente Mantido" }, lista_clientes_excluidos), "Centralizador\\clientes_excluidos.txt");
            Utils.CriarTXT($"Centralizador de dados\nImplantação{Configuracoes.Default.CodigoImplantacao}\n\n" + Utils.ExportRegToText(new string[] { "Codigo Cliente Excluido", "Razao Cliente Excluido", "CPF" }, lista_clientes_alterados) + "\n\nCPF Antigo salvo no campo `ReferenciaContato1`", "Centralizador\\clientes_alterados.txt");

        }

        public void AjustarProdutos(ProgressBarControl pbImportacao)
        {
            IDbCommand cmd_update_insert = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();
            int qtd_execucoes;

            pbImportacao.Invoke((MethodInvoker)(() =>
            {
                pbImportacao.Properties.Maximum = 6;
                pbImportacao.EditValue = 0;
            }));


            #region Produto EAN-8
            qtd_execucoes = Convert.ToInt32(ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar($"select count(*) from produtos where char_length(trim(leading '0' from codigobarras)) >= 8 and ativo != 0 group by codigobarras having count(codigobarras)>1 order by count(*) desc limit 1"));
            for(int i=1; i < qtd_execucoes; i++)
            {
                cmd_update_insert.CommandText = "update	produtos	join (select codigo, codigobarras from produtos	where char_length(trim(leading '0' from codigobarras)) >= 8 and ativo != 0 group by codigobarras having	count(codigobarras)>1	order by codigo asc ) bb on produtos.CodigoBarras = bb.codigobarras	set status = 'x', ativo =0, UserID = 'Importacao', UsuarioExclusao =1,	TerminalExclusao ='IMPORTACAO', MotivoExclusao=concat('PRODUTO DUPLICADO, MANTIDO: ', bb.codigo),DataHoraExclusao =now(),	InfNutri_CodigoAdicional_429 = bb.codigo	where produtos.CodigoBarras = bb.codigobarras and produtos.codigo <> bb.codigo and produtos.ativo != 0";
                cmd_update_insert.ExecuteNonQuery();
                pbImportacao.Invoke((MethodInvoker)(() => pbImportacao.PerformStep()));
            }
            #endregion

            #region Produtos com Código Interno
            qtd_execucoes = Convert.ToInt32(ConexaoManager.instancia.GetConexaoMyCommerce().ExecuteScalar($"select count(*) from produtos where char_length(trim(leading '0' from codigobarras)) < 8 and ativo != 0 group by codigobarras having count(codigobarras)>1 order by count(*) desc limit 1"));
            for (int i = 1; i < qtd_execucoes; i++)
            {
                cmd_update_insert.CommandText = "update	produtos join (	select		codigo,		descricao	from		produtos	where		char_length(trim(leading '0' from codigobarras)) < 8		and ativo != 0	group by		Descricao 	having		count(Descricao)>1	order by		codigo asc ) bb on	produtos.descricao = bb.descricao set	status = 'x',	ativo = 0,	UserID = 'Importacao',	UsuarioExclusao = 1,	TerminalExclusao = 'IMPORTACAO',	MotivoExclusao = concat('PRODUTO DUPLICADO, MANTIDO: ', bb.codigo),	DataHoraExclusao = now(),	InfNutri_CodigoAdicional_429 = bb.codigo where	produtos.descricao = bb.descricao	and produtos.codigo <> bb.codigo	and produtos.ativo != 0";
                cmd_update_insert.ExecuteNonQuery();
                pbImportacao.Invoke((MethodInvoker)(() => pbImportacao.PerformStep()));
            }
            #endregion

            //Atualiza estoque do produto duplicado para o produto correto;
            foreach (var estoque in new string[] { "produtosestoque", "acertoestoque", "auditoriaestoque" })
            {
                cmd_update_insert.CommandText = $"update {estoque} 	join produtos on {estoque}.CodigoProduto = produtos.Codigo	set {estoque}.CodigoProduto = cast(produtos.InfNutri_CodigoAdicional_429 as integer)	where produtos.Ativo = 0";
                cmd_update_insert.ExecuteNonQuery();
                pbImportacao.Invoke((MethodInvoker)(() => pbImportacao.PerformStep()));
            }

            //Atualiza o valor das tabelas de preco
            cmd_update_insert.CommandText = $"update tabelas_preco_produto join produtos on tabelas_preco_produto.CodigoProduto = produtos.InfNutri_CodigoAdicional_429 and produtos.CodigoCampoExtra1 = tabelas_preco_produto.empresa set tabelas_preco_produto.preco = produtos.vendat1 where produtos.Ativo = 0";
            cmd_update_insert.ExecuteNonQuery();
            pbImportacao.Invoke((MethodInvoker)(() => pbImportacao.PerformStep()));
        }

        internal void AjustarSecoes(ProgressBarControl pbImportacao)
        {
            var cmd_centralizar = ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando();

            pbImportacao.Invoke((MethodInvoker)(() =>
            {
                pbImportacao.Properties.Maximum = 7;
                pbImportacao.EditValue = 0;
            }));

            foreach (var tabela in new string[] { "secoes", "grupos", "subgrupos" })
            {
                cmd_centralizar.CommandText = $"update {tabela} join (select codigo, Descricao, min(coalesce(magento_id, 1)) as magento_id from {tabela} where excluido is null group by descricao having count(*)>1) ss on {tabela}.Descricao = ss.descricao set  UltimaAlteracao=now(), Excluido=1, DataExclusao=now(), UsuarioExclusao=1, terminalExclusao='IMPORTACAO' where {tabela}.Descricao = ss.descricao and {tabela}.codigo <> ss.codigo";
                cmd_centralizar.ExecuteNonQuery();
                pbImportacao.Invoke((MethodInvoker)(() => pbImportacao.PerformStep()));
            }

            #region Centraliza Fabricantes
            cmd_centralizar.CommandText = "update Fabricantes join (select codigo, Descricao, min(cast(coalesce(substring(CNPJ, 18), 1) as integer)) as magento_id from fabricantes where cancelado is null group by descricao having count(*)>1) ff on fabricantes.Descricao = ff.descricao set UltimaAlteracao = now(), Cancelado =1 where fabricantes.codigo <> ff.codigo and fabricantes.Descricao = ff.descricao";
            cmd_centralizar.ExecuteNonQuery();
            pbImportacao.Invoke((MethodInvoker)(() => pbImportacao.PerformStep()));
            #endregion

            #region Atualiza Grupos e Subgrupos para ficarem com parentes corretos
            cmd_centralizar.CommandText = "update grupos join secoes on grupos.DescricaoSecao = secoes.Descricao and secoes.Excluido is null set CodigoSecao = secoes.Codigo , DescricaoSecao = secoes.Descricao;";
            cmd_centralizar.CommandText += " update subgrupos join grupos on subgrupos.DescricaoGrupo = grupos.Descricao and grupos.Excluido is null set Codigogrupo = grupos.Codigo , descricaogrupo = grupos.Descricao;";
            cmd_centralizar.ExecuteNonQuery();
            pbImportacao.Invoke((MethodInvoker)(() => pbImportacao.PerformStep()));
            #endregion

            #region Reseta campos utilizados para centralizar
            cmd_centralizar.CommandText = "UPDATE secoes set magento_id = null; UPDATE grupos set magento_id = null; UPDATE subgrupos set magento_id = null; UPDATE fabricantes set cnpj = null;";
            cmd_centralizar.ExecuteNonQuery();
            pbImportacao.Invoke((MethodInvoker)(() => pbImportacao.PerformStep()));
            #endregion

            #region Atualiza as informações dos produtos para os campos corretos
            cmd_centralizar.CommandText = "CREATE INDEX idxProdSec on produtos (Secao); CREATE INDEX idxSec on Secoes (Descricao)";
            cmd_centralizar.ExecuteNonQuery();
            cmd_centralizar.CommandText = "CREATE INDEX idxProdGrp on produtos (Grupo); CREATE INDEX idxGrp on Grupos (Descricao)";
            cmd_centralizar.ExecuteNonQuery();
            cmd_centralizar.CommandText = "CREATE INDEX idxProdSGrp on produtos (SubGrupo); CREATE INDEX idxSGrp on SubGrupos (Descricao)";
            cmd_centralizar.ExecuteNonQuery();
            cmd_centralizar.CommandText = "CREATE INDEX idxProdFab on produtos (Fabricante); CREATE INDEX idxFab on Fabricantes (Descricao)";
            cmd_centralizar.ExecuteNonQuery();


            cmd_centralizar.CommandText = "UPDATE produtos join secoes on produtos.Secao = secoes.descricao and secoes.excluido is null set CodigoSecao=secoes.codigo, Secao=secoes.descricao;";
            cmd_centralizar.ExecuteNonQuery();
            cmd_centralizar.CommandText = "UPDATE produtos join grupos on produtos.Grupo = grupos.descricao and grupos.excluido is null set CodigoGrupo=grupos.codigo, Grupo=grupos.descricao;";
            cmd_centralizar.ExecuteNonQuery();
            cmd_centralizar.CommandText = "UPDATE produtos join subgrupos on produtos.subGrupo = subgrupos.descricao and subgrupos.excluido is null set CodigosubGrupo=subgrupos.codigo, subGrupo=subgrupos.descricao;";
            cmd_centralizar.ExecuteNonQuery();
            cmd_centralizar.CommandText = "UPDATE produtos join fabricantes on produtos.fabricante = fabricantes.descricao and fabricantes.cancelado is null set CodigoFabricante=fabricantes.codigo, Fabricante=fabricantes.descricao;";
            cmd_centralizar.ExecuteNonQuery();

            cmd_centralizar.CommandText = "ALTER TABLE produtos DROP INDEX idxProdSec, DROP INDEX idxProdGrp, DROP INDEX idxProdSGrp, DROP INDEX idxProdFab";
            cmd_centralizar.ExecuteNonQuery();
            cmd_centralizar.CommandText = "ALTER TABLE Secoes DROP INDEX idxSec; ALTER TABLE Grupos DROP INDEX idxGrp; ALTER TABLE Subgrupos DROP INDEX idxSGrp; ALTER TABLE Fabricantes DROP INDEX idxFab";
            cmd_centralizar.ExecuteNonQuery();

            pbImportacao.Invoke((MethodInvoker)(() => pbImportacao.PerformStep()));
            #endregion
        }
    }
}
