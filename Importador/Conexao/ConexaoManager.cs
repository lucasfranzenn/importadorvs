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
    }

}
