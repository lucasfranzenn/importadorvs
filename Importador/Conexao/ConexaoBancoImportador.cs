using static Importador.Classes.Constantes;
using Microsoft.Data.Sqlite;
using System.Linq;
using Dapper;
using Importador.Classes.Entidades;
using static Importador.Properties.Configuracoes;
using System;
using DevExpress.Mvvm.Native;

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

        public static void InserirRegistro(object obj, Enums.TabelaBancoLocal tabela)
        {
            Type entidade = obj.GetType();

            var query = $"insert into {tabela.ToString()} {GetCamposTabela(entidade, Enums.Dml.Insert)}";

            instancia.conexao.Execute(query, obj);
        }

        private static string GetCamposTabela(Type entidade, Enums.Dml tipoDML) => tipoDML switch
        {
            Enums.Dml.Insert => $"({string.Join(",", entidade.GetProperties().Select(p => $"{p.Name}"))}) values (null, {string.Join(",", entidade.GetProperties().Skip(1).Select(p => $"@{p.Name}"))})",
            Enums.Dml.Update => string.Join(",", entidade.GetProperties().Skip(1).Select(p => $"{p.Name} = @{p.Name}")),
            Enums.Dml.Select => string.Empty,
            _ => string.Empty
        };

        public static T GetEntidade<T>(Enums.TabelaBancoLocal tabela) where T : class
        {
            var ListaEntidades = instancia.conexao.Query<T>($"select * from {tabela.ToString()} where CodigoImplantacao = {Default.CodigoImplantacao}");

            if (ListaEntidades.FirstOrDefault() is T entidade)
            {
                return entidade;
            }

            throw new NullReferenceException();
        }

        public static T GetEntidade<T>(Enums.TabelaBancoLocal tabela, string where) where T : class
        {
            var ListaEntidades = instancia.conexao.Query<T>($"select * from {tabela.ToString()} where CodigoImplantacao = {Default.CodigoImplantacao} and {where}");

            if (ListaEntidades.FirstOrDefault() is T entidade)
            {
                return entidade;
            }

            throw new NullReferenceException();
        }

        internal static void Update(object obj, Enums.TabelaBancoLocal tabela)
        {
            Type entidade = obj.GetType();

            string chavePrimaria = GetChavePrimaria(entidade);

            string query = $"Update {tabela.ToString()} set {GetCamposTabela(entidade, Enums.Dml.Update)} where {chavePrimaria} = @{chavePrimaria}";

            instancia.conexao.Execute(query, obj);
        }

        private static string GetChavePrimaria(Type entidade)
        {
            return string.Join("", entidade.GetProperties().Take(1).Select(p => $"{p.Name}"));
        }
    }
}
