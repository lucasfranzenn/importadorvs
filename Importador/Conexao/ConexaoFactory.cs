using System;
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
                case Enums.TipoBanco.Access:
                    return new MSAccessConnection();
                default:
                    throw new NotSupportedException($"O banco de dados '{tipoBanco.ToString()}' não é suportado ou não foi implementado.");
            }
        }
    }
}
