using static Importador.Classes.Constantes;
using Microsoft.Data.Sqlite;
using System.Linq;
using Dapper;
using Importador.Classes.Entidades;
using static Importador.Properties.Configuracoes;
using System;

namespace Importador.Conexao
{
    public class ConexaoBancoImportador
    {
        public SqliteConnection conexao = new SqliteConnection("Data Source="+ Default.BancoLocal);
        public static ConexaoBancoImportador instancia = new();

        public ConexaoBancoImportador()
        {
            conexao.Open();
        }

        public static void Executar(string comandoSQL)
        {
            SqliteCommand cmd = new SqliteCommand(comandoSQL, instancia.conexao);
            cmd.ExecuteNonQuery();
        }

        public static Implantacao GetImplantacao()
        {
            var ListaImplantacoes = instancia.conexao.Query<Implantacao>($"select * from implantacoes where codigoimplantacao = {Default.CodigoImplantacao}");

            if (ListaImplantacoes.FirstOrDefault() is Implantacao implantacao)
            {
                return implantacao;
            }

            throw new Exception("Este código de implantação não existe!\nDeseja cadastrar?");
        }

        internal static void Update(object obj, Enums.TabelaBancoLocal tabela)
        {
            Type entidade = obj.GetType();

            string chavePrimaria = GetChavePrimaria(tabela.ToString());

            string query = $"Update {tabela.ToString()} set {string.Join(",", entidade.GetProperties()
                                                                                        .Where(p => p.Name != $"{chavePrimaria}")
                                                                                        .Select(p => $"{p.Name} = @{p.Name}"))} where {chavePrimaria} = @{chavePrimaria}";

            instancia.conexao.Execute(query, obj);
        }

        private static string GetChavePrimaria(string tabela)
        {
            return instancia.conexao.ExecuteScalar($"SELECT l.name FROM pragma_table_info('{tabela}') as l WHERE l.pk = 1").ToString();
        }
    }
}
