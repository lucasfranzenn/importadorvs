using Importador.Classes.JSON;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Conexao
{
    public class ConexaoManager
    {
        private readonly IDbConnection _conexaoMariaDB;
        private readonly IDbConnection _conexaoImportacao;
        public static ConexaoManager instancia = new();

        public ConexaoManager()
        {
            _conexaoMariaDB = new MariaDbConnection().CriarConexao(ConexoesJson.GetConnectionString("mycommerce"));

            var genericDbFactory = ConexaoFactory.CriarConexaoBanco(ConexoesJson.GetTipoBancoImportacao());
            _conexaoImportacao = genericDbFactory.CriarConexao(ConexoesJson.GetConnectionString("importacao"));

            try
            {
                _conexaoMariaDB.Open();
                _conexaoImportacao.Open();
            }
            catch (Exception)
            {
                throw;
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

        public void CloseConnections()
        {
            _conexaoMariaDB.Close();
            _conexaoImportacao.Close();
        }
    }

}
