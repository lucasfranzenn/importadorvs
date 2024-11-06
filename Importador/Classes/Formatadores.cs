using System;
using System.Linq;

namespace Importador.Classes
{
    public static class Formatadores
    {
        public static object FormataNCM(object ncm)
        {
            if (string.IsNullOrWhiteSpace(ncm.ToString())) return DBNull.Value;

            string ncmString = new string(ncm.ToString().Where(char.IsDigit).ToArray()).PadRight(8, '0');

            return $"{ncmString.Substring(0, 4)}.{ncmString.Substring(4, 2)}.{ncmString.Substring(6, 2)}";
        }

        internal static object FormataCEP(object cep)
        {
            string cepString = new string(cep.ToString().Where(char.IsDigit).ToArray()).PadRight(8, '0');

            return string.IsNullOrEmpty(cepString) ? "" : $"{cepString.Substring(0, 2)}.{cepString.Substring(2, 3)}-{cepString.Substring(5, 3)}";
        }

        internal static object FormataCNPJ(object cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj.ToString())) return DBNull.Value;

            string cnpjString = new string(cnpj.ToString().Where(char.IsDigit).ToArray()).PadLeft(14, '0');

            return $"{cnpjString.Substring(0, 2)}.{cnpjString.Substring(2, 3)}.{cnpjString.Substring(5, 3)}/{cnpjString.Substring(8, 4)}-{cnpjString.Substring(12, 2)}";
        }

        internal static object FormataCPF(object cpf)
        {
            if (string.IsNullOrEmpty(cpf.ToString())) return DBNull.Value;

            string cpfString = new string(cpf.ToString().Where(char.IsDigit).ToArray());

            cpfString = cpfString.PadLeft(11, '0');

            return $"{cpfString.Substring(0, 9)}-{cpfString.Substring(9, 2)}";
        }

        internal static object FormataData(object data)
        {
            return (data is DBNull) ? Convert.ToDateTime("1999-01-01") : data;
        }

        internal static object FormataTelefone(object fone)
        {
            string foneString = new string(fone.ToString().Where(char.IsDigit).ToArray());

            if (foneString.Length == 11 || foneString.Length == 9)
            {
                foneString = foneString.PadLeft(11, '0');
                return Convert.ToInt64(foneString) == 0 ? DBNull.Value : $"({foneString.Substring(0, 2)}){foneString.Substring(2, 5)}-{foneString.Substring(7, 4)}"; 
            }

            foneString = foneString.PadLeft(10, '0');

            return Convert.ToInt64(foneString) == 0 ? DBNull.Value : $"({foneString.Substring(0, 2)}){foneString.Substring(2, 4)}-{foneString.Substring(6, 4)}";
        }
    }
}
