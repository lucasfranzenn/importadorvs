using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes
{
    public static class Constantes
    {
        public static class Caminhos
        {
            public const string ImplantacaoJson = @"Configuracao\implantacao.json";
            public const string ConexoesJson = @"Configuracao\conexoes.json";
            public const string ConsultasJson = @"Configuracao\consultas.json";
            public const string SkinTxt = @"Configuracao\skin.txt";
            public const string ImportadorDb = @"Configuracao\imp.db";
        }
        
        public static class Enums
        {
            public enum Sistema
            {
                Importacao,
                MyCommerce
            }

            public enum Tabela
            {
                clientes,
                produtos,
                estoque
            }
        }

        public static class Mapeamento
        {
            public static readonly Dictionary<string, string> TipoBancoPorNome = new()
            {
                {"MySQL", "mysql"},
                {"Firebird", "firebird"},
                {"PostgreSQL", "postgre"},
                {"MS-SQL \\ SQLServer", "mssql"},
                {"Access", "access"},
                {"ConnectionString", "connectionstring"}
            };

            public static readonly Dictionary<string, string> NomePorTipoBanco = new()
            {
                {"mysql", "MySQL"},
                {"firebird", "Firebird"},
                {"postgre" , "PostgreSQL"},
                {"mssql", "MS-SQL \\ SQLServer"},
                {"access" , "Access"},
                {"connectionstring" , "ConnectionString"}
            };

            public static readonly Dictionary<string, List<string>> TabelasTruncatePorTabela = new()
            {
                {"clientes", new List<string> { "clientes" } },
                {"estoque", new List<string> { "produtosestoque", "acertoestoque", "auditoriaestoque"} }
            };

            public static readonly Dictionary<string, List<Func<object, object>>> FuncoesFormatadorasPorColuna = new()
            {
                {"ncm",  new List<Func<object, object>> { Formatadores.FormataNCM } }
            };
        }

    }

}
