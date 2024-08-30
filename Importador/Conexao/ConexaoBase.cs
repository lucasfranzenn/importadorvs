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
using Importador.Classes.JSON;
using System.Security.Cryptography.X509Certificates;

namespace Importador.Conexao
{
    public abstract class ConexaoBase
    {
        public abstract IDbConnection CriarConexao(Importacao conexao);
    }

    public class MariaDbConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(Importacao conexao)
        {
            return new MySqlConnection($"Server={conexao.Host};Port={conexao.Porta};Database={conexao.Banco};Uid={conexao.Usuario};Pwd={conexao.Porta};");
        }
    }

    public class PostgreSqlConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(Importacao conexao)
        {
            return new NpgsqlConnection($"Host={conexao.Host};Port={conexao.Porta};Database={conexao.Banco};User ID={conexao.Usuario};Password={conexao.Porta};");
        }
    }

    public class FirebirdConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(Importacao conexao)
        {
            return new FbConnection($"DataSource={conexao.Host};Port={conexao.Porta};Database={conexao.Banco};User={conexao.Usuario};Password={conexao.Porta};Charset=NONE");
        }
    }
}
