using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes
{
    public static class Formatadores
    {
        public static object FormataNCM(object ncm) => ncm.ToString().Replace('.', ' ');
    }
}
