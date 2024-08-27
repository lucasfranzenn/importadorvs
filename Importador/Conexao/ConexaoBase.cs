using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Npgsql;
using FirebirdSql.Data.FirebirdClient;

namespace Importador.Conexao
{
    public abstract class ConexaoBase
    {
        public abstract IDbConnection CriarConexao(string stringConexao);
    }

    public class MariaDbConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(string stringConexao)
        {
            return new MySqlConnection(stringConexao);
        }
    }

    public class PostgreSqlConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(string stringConexao)
        {
            return new NpgsqlConnection(stringConexao);
        }
    }

    public class FirebirdConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(string stringConexao)
        {
            return new FbConnection(stringConexao);
        }
    }
}
