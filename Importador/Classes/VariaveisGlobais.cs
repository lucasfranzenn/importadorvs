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

        public static Dictionary<string, string> TipoBancoCombo = new()
        {
            {"MySQL", "mysql"},
            {"Firebird", "firebird"},
            {"PostgreSQL", "postgre"},
            {"MS-SQL \\ SQLServer", "mssql"},
            {"Acess", "acess"},
            {"ConnectionString", "connectionstring"}
        };

        public static Dictionary<string, string> TipoBancoComboReverso = new()
        {
            {"mysql", "MySQL"},
            {"firebird", "Firebird"},
            {"postgre" , "PostgreSQL"},
            {"MS-SQL \\ SQLServer", "mssql"},
            {"acess" , "Acess"},
            {"connectionstring" , "ConnectionString"}
        };

    }

}
