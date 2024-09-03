using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes
{
    public static class VariaveisGlobais
    {
        public const string PathConexoesJson = @"data\conexoes.json";
        public const string PathConsultasJson = @"data\consultas.json";
        public const string PathSkinTxt = @"data\skin.txt";

        public enum Sistema
        {
            Importacao,
            MyCommerce
        }

        public enum Tabelas
        {
            clientes,
            produtos,
            estoque
        }

        public static Dictionary<string, string> TipoBancoCombo = new()
        {
            {"MySQL", "mysql"},
            {"Firebird", "firebird"},
            {"PostgreSQL", "postgre"},
            {"MS-SQL \\ SQLServer", "mssql"},
            {"Access", "access"},
            {"ConnectionString", "connectionstring"}
        };

        public static Dictionary<string, string> TipoBancoComboReverso = new()
        {
            {"mysql", "MySQL"},
            {"firebird", "Firebird"},
            {"postgre" , "PostgreSQL"},
            {"MS-SQL \\ SQLServer", "mssql"},
            {"access" , "Access"},
            {"connectionstring" , "ConnectionString"}
        };

        public static Dictionary<string, List<string>> TabelasTruncate = new()
        {
            {"clientes", new List<string> { "clientes" } },
            {"estoque", new List<string> { "produtosestoque", "acertoestoque", "auditoriaestoque"} }
        };

        public static Dictionary<string, List<Func<object, object>>> FuncoesColuna = new()
        {
            {"ncm",  new List<Func<object, object>> { Formatador.FormataNCM } },
            {"razaosocial", new List<Func<object, object>> { Formatador.Franzen, Formatador.Lucas} }

        };

    }

}
