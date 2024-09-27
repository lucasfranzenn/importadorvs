using DevExpress.Xpo.Metadata.Helpers;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Importador.Classes.Constantes;

namespace Importador.Conexao
{
    public static class ConexaoFactory
    {
        public static ConexaoBase CriarConexaoBanco(Enums.TipoBanco tipoBanco)
        {
            switch (tipoBanco)
            {
                case Enums.TipoBanco.MySQL:
                    return new MariaDbConnection();
                case Enums.TipoBanco.Firebird:
                    return new FirebirdConnection();
                case Enums.TipoBanco.PostgreSQL:
                    return new PostgreSqlConnection();
                case Enums.TipoBanco.SQLServer:
                    return new MSSqlConnection();
                default:
                    throw new NotSupportedException($"O banco de dados '{tipoBanco.ToString()}' não é suportado ou não foi implementado.");
            }
        }
    }
}
