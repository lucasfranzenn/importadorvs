using static Importador.Classes.Constantes;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Importador.Conexao
{
    public class ConexaoBancoImportador
    {
        public SqliteConnection conexao = new SqliteConnection("Data Source="+ Caminhos.BancoImportador);
        public static ConexaoBancoImportador instancia = new();

        public ConexaoBancoImportador()
        {
            conexao.Open();
        }

        public static void Executar(string comandoSQL)
        {
            SqliteCommand cmd = new SqliteCommand(comandoSQL, instancia.conexao);
            cmd.ExecuteNonQuery();
        }
    }
}
