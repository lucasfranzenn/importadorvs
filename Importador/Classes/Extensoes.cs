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
            cmd.CommandTimeout = 180;

            return cmd;
        }
    }
}
