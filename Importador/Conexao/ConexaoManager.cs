using Importador.Classes.JSON;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Importador.Classes.VariaveisGlobais;

namespace Importador.Conexao
{
    public class ConexaoManager
    {
        private readonly IDbConnection _conexaoMariaDB;
        private readonly IDbConnection _conexaoImportacao;
        public static ConexaoManager instancia = new();

        public ConexaoManager()
        {
            _conexaoMariaDB = new MariaDbConnection().CriarConexao(ConexoesJson.GetConnectionString(Sistema.MyCommerce));

            var genericDbFactory = ConexaoFactory.CriarConexaoBanco(ConexoesJson.GetTipoBancoImportacao());
            _conexaoImportacao = genericDbFactory.CriarConexao(ConexoesJson.GetConnectionString(Sistema.Importacao));

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
            if(_conexaoMariaDB != null)
            {
                _conexaoMariaDB.Close();
            }
            _conexaoMariaDB.Open();

            return _conexaoMariaDB;
        }

        public IDbConnection GetConexaoImportacao()
        {
            if(_conexaoImportacao != null)
            {
                _conexaoImportacao.Close();
            }
            _conexaoImportacao.Open();
            return _conexaoImportacao;
        }

        public void CloseConnections()
        {
            _conexaoMariaDB.Close();
            _conexaoImportacao.Close();
        }
    }

}
