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
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }
        }

        public static bool ConexoesAbertas()
        {
            instancia.CloseConnections();
            instancia = new();
            if (instancia._conexaoImportacao.State == ConnectionState.Open && instancia._conexaoMariaDB.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

        public static IDbConnection GetConexaoMyCommerce()
        {
            if(instancia._conexaoMariaDB != null)
            {
                instancia._conexaoMariaDB.Close();
            }
            instancia = new();

            return instancia._conexaoMariaDB;
        }

        public static IDbConnection GetConexaoImportacao()
        {
            if(instancia._conexaoImportacao != null)
            {
                instancia._conexaoImportacao.Close();
            }
            instancia = new();
            return instancia._conexaoImportacao;
        }

        public void CloseConnections()
        {
            _conexaoMariaDB.Close();
            _conexaoImportacao.Close();
        }
    }

}
