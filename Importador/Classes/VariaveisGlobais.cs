using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes
{
    public static class VariaveisGlobais
    {
        public const string PathConexoesJson = @"data\conexoes.json";
        public const string PathConsultasJson = @"data\consultas.json";
        public const string PathSkinTxt = @"data\skin.txt";

        public enum Sistema
        {
            Importacao,
            MyCommerce
        }
    }
}
