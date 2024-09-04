using DevExpress.Office.Crypto;
using Importador.Classes.JSON;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Importador.Classes.VariaveisGlobais;
using static Importador.Classes.Utils;
using DevExpress.CodeParser;
using Npgsql;
using FirebirdSql.Data.FirebirdClient;
using System.Data.SqlClient;

namespace Importador.Conexao
{
    public class ConexaoManager
    {
        private readonly IDbConnection _conexaoMariaDB;
        private readonly IDbConnection _conexaoImportacao;
        public static ConexaoManager instancia = new();

        public ConexaoManager()
        {
            _conexaoMariaDB = new MariaDbConnection().CriarConexao(GetImportacao(Sistema.MyCommerce));

            var genericDbFactory = ConexaoFactory.CriarConexaoBanco(ConexoesJson.GetTipoBancoImportacao());
            _conexaoImportacao = genericDbFactory.CriarConexao(GetImportacao(Sistema.Importacao));

            try
            {
               _conexaoMariaDB.Open();
               _conexaoImportacao.Open();
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }
        }

        public IDbConnection GetConexaoMyCommerce()
        {
            return _conexaoMariaDB;
        }

        public IDbConnection GetConexaoImportacao()
        {
            return _conexaoImportacao;
        }

        public static bool ConexoesAbertas()
        {
            instancia.CloseConnections();
            instancia = new();
            return ((instancia._conexaoImportacao.State == ConnectionState.Open && instancia._conexaoMariaDB.State == ConnectionState.Open));
        }

        public void CloseConnections()
        {
            _conexaoMariaDB.Close();
            _conexaoImportacao.Close();
        }

        public string GetProcurarColunaQuery(string coluna) => _conexaoImportacao switch
        {
            (MySqlConnection) => $"SELECT TABLE_NAME AS TABELA, COLUMN_NAME AS COLUNA FROM information_schema.columns WHERE TABLE_SCHEMA = '{GetImportacao(Sistema.Importacao).Banco}' AND COLUMN_NAME LIKE '%{coluna}%' ORDER BY TABLE_NAME, ordinal_position",
            (SqlConnection) => $"SELECT T.name AS Tabela, C.name AS Coluna FROM sys.sysobjects AS T (NOLOCK) INNER JOIN sys.all_columns AS C (NOLOCK) ON T.id = C.object_id AND T.XTYPE = 'U' where upper(C.NAME) LIKE upper('%{coluna}%') ORDER BY T.name ASC",
            (FbConnection) => $"select rdb$relation_name as tabela, rdb$field_name AS coluna from rdb$relation_fields where upper(rdb$field_name) like upper('%{coluna}%')  ORDER BY rdb$relation_name",
            (NpgsqlConnection) => $"SELECT table_name as tabela, column_name as coluna FROM information_schema.columns WHERE upper(column_name) like upper('%{coluna}%') order by table_name",
            _ => null
        };



    }

}
