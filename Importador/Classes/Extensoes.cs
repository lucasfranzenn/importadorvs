using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes
{
    public static class Extensoes
    {
        public static IDbCommand CriarComando(this IDbConnection con)
        {
            var cmd = con.CreateCommand();
            cmd.CommandTimeout = 300;

            return cmd;
        }

        public static StringBuilder AdicionarLinhaLog(this StringBuilder sb, string msg)
        {
            string horario = DateTime.Now.ToString("[dd/MM/yyyy - HH:mm]");

            sb.AppendLine($"{horario} {msg}");

            return sb;
        }
    }
}
