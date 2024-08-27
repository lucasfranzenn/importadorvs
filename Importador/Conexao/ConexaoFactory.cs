using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Conexao
{
    public static class ConexaoFactory
    {
        public static ConexaoBase CriarConexaoBanco(string tipoBanco)
        {
            switch (tipoBanco.ToLower())
            {
                case "mysql":
                    return new MariaDbConnection();
                case "postgresql":
                    return new PostgreSqlConnection();
                case "firebird":
                    return new FirebirdConnection();
                case "mariadb":
                    return new MariaDbConnection();
                default:
                    throw new NotSupportedException($"O banco de dados '{tipoBanco}' não é suportado.");
            }
        }
    }
}
