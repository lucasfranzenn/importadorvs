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
using Ent = Importador.Classes.Entidades;

namespace Importador.Conexao
{
    public abstract class ConexaoBase
    {
        public abstract IDbConnection CriarConexao(Ent.Conexao conexao);
    }

    public class MariaDbConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(Ent.Conexao conexao)
        {
            return new MySqlConnection($"Server={conexao.Host};Port={conexao.Porta};Database={conexao.Banco};Uid={conexao.Usuario};Pwd={conexao.Senha};");
        }
    }

    public class PostgreSqlConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(Ent.Conexao conexao)
        {
            return new NpgsqlConnection($"Host={conexao.Host} ;Port= {conexao.Porta}  ;Database=  {conexao.Banco}  ;User ID=  {conexao.Usuario}  ;Password=  {conexao.Senha};");
        }
    }

    public class FirebirdConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(Ent.Conexao conexao)
        {
            return new FbConnection($"DataSource={conexao.Host}  ;Port=  {conexao.Porta}  ;Database=  {conexao.Banco}  ;User=  {conexao.Usuario}  ;Password=  {conexao.Senha};Charset=NONE");
        }
    }

    public class MSSqlConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(Ent.Conexao conexao)
        {
            return new SqlConnection($"Server={conexao.Host};Database={conexao.Banco};Trusted_Connection=yes");
            /* String de conexão caso precise se conectar em um servidor dedicado.
            return new SqlConnection($"Server={conexao.Host},{conexao.Porta};Database={conexao.Banco};User Id={conexao.Usuario};Password={conexao.Senha}"); */
        }
    }

    public class ConnectionStringConnection : ConexaoBase
    {
        public override IDbConnection CriarConexao(Ent.Conexao conexao)
        {
            throw new NotImplementedException();
        }
    }
}
