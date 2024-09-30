using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Importador.Classes
{
    public static class Formatadores
    {
        public static object FormataNCM(object ncm) 
        {
            string ncmString = new string(ncm.ToString().Where(char.IsDigit).ToArray());

            return $"{ncmString.Substring(0, 4)}.{ncmString.Substring(4, 2)}.{ncmString.Substring(6, 2)}";
        }

        internal static object FormataCEP(object cep)
        {
            string cepString = new string(cep.ToString().Where(char.IsDigit).ToArray());

            return string.IsNullOrEmpty(cepString) ? "" : $"{cepString.Substring(0,2)}.{cepString.Substring(2, 3)}-{cepString.Substring(5, 3)}";
        }

        internal static object FormataCNPJ(object cnpj)
        {
            string cnpjString = new string(cnpj.ToString().Where(char.IsDigit).ToArray()).PadLeft(14, '0');

            return $"{cnpjString.Substring(0, 2)}.{cnpjString.Substring(2, 3)}.{cnpjString.Substring(5, 3)}/{cnpjString.Substring(8, 4)}-{cnpjString.Substring(12, 2)}";
        }

        internal static object FormataCPF(object cpf)
        {
            if (string.IsNullOrEmpty(cpf.ToString())) return "";

            string cpfString = new string(cpf.ToString().Where(char.IsDigit).ToArray());

            cpfString = cpfString.PadLeft(11, '0');

            return $"{cpfString.Substring(0, 9)}-{cpfString.Substring(9, 2)}";
        }

        internal static object FormataTelefone(object fone)
        {
            var caracteresIndesejados = new string[] { "(", ")", " ", "-" };

            string foneString = new string(fone.ToString().Where(char.IsDigit).ToArray()).PadLeft(11, '0');

            return $"({foneString.Substring(0, 2)}){foneString.Substring(2, 5)}-{foneString.Substring(7, 4)}";
        }
    }
}
