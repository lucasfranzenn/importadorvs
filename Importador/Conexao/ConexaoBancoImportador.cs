using Dapper;
using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors;
using Importador.Classes.Entidades;
using Importador.Properties;
using Importador.UserControls.Componentes;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using static Importador.Classes.Constantes;

namespace Importador.Conexao
{
    public class ConexaoBancoImportador
    {
        public SqliteConnection conexao = new SqliteConnection("Data Source=" + Configuracoes.Default.BancoLocal);
        public static ConexaoBancoImportador instancia = new();

        public ConexaoBancoImportador()
        {
            conexao.Open();
        }

        public static void InserirRegistro(object obj, Enums.TabelaBancoLocal tabela)
        {
            Type entidade = obj.GetType();

            var query = $"insert into {tabela.ToString()} {GetCamposTabela(entidade, Enums.Dml.Insert)}";

            instancia.conexao.Execute(query, obj);
        }

        private static string GetCamposTabela(Type entidade, Enums.Dml tipoDML) => tipoDML switch
        {
            Enums.Dml.Insert => $"({string.Join(",", entidade.GetProperties().Select(p => $"{p.Name}"))}) values ({string.Join(",", entidade.GetProperties().Select(p => $"@{p.Name}"))})",
            Enums.Dml.Update => string.Join(",", entidade.GetProperties().Skip(1).Select(p => $"{p.Name} = @{p.Name}")),
            Enums.Dml.Select => string.Empty,
            _ => string.Empty
        };

        public static T GetEntidade<T>(Enums.TabelaBancoLocal tabela) where T : class
        {
            var ListaEntidades = instancia.conexao.Query<T>($"select * from {tabela.ToString()} where CodigoImplantacao = {Configuracoes.Default.CodigoImplantacao}");

            if (ListaEntidades.FirstOrDefault() is T entidade)
            {
                return entidade;
            }

            return null;
        }

        public static T GetEntidade<T>(Enums.TabelaBancoLocal tabela, string where) where T : class
        {
            var ListaEntidades = instancia.conexao.Query<T>($"select * from {tabela.ToString()} where CodigoImplantacao = {Configuracoes.Default.CodigoImplantacao} and {where}");

            if (ListaEntidades.FirstOrDefault() is T entidade)
            {
                return entidade;
            }

            return null;
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

        internal static string GetSql(string tabela)
        {
            var resultado = instancia.conexao.Query<Consultas>($"select consulta from consultas where tabelaconsulta = '{tabela}' and codigoimplantacao = {Configuracoes.Default.CodigoImplantacao}");

            if (resultado.FirstOrDefault() is Consultas c)
            {
                return c.Consulta;
            }

            try
            {
                return Classes.Utils.GetSqlPadrao(tabela);
            }
            catch (System.Configuration.SettingsPropertyNotFoundException)
            {
                return $"select * from {tabela}";
            }
        }

        internal static void AtualizarConexaoPadrao(Classes.Entidades.Conexao conexao)
        {
            string query = "UPDATE CONEXOES SET PADRAO = 0 WHERE CODIGOCONEXAO != @CodigoConexao AND CODIGOIMPLANTACAO = @CodigoImplantacao and TIPOCONEXAO = 1";

            instancia.conexao.Execute(query, conexao);
        }

        internal static void AtualizaParametros(TabelaMyCommerce tela, List<CheckEdit> listaParametros)
        {
            Parametro param;

            foreach (var parametro in listaParametros)
            {
                param = GetEntidade<Parametro>(Enums.TabelaBancoLocal.parametros, $"Tela = '{tela.Tabela}' and NomeParametro = '{parametro.Name}'");

                if (param is null) InserirRegistro(new Parametro(tela, parametro), Enums.TabelaBancoLocal.parametros);

                param.Valor = parametro.Checked;
                Update(param, Enums.TabelaBancoLocal.parametros);
            }
        }
    }
}
