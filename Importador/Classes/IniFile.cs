using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes
{
    public class IniFile
    {
        private string _path;
        public string EXE = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder result, int size, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern int WritePrivateProfileString(string section, string key, string value, string filePath);

        public IniFile(string arquivo)
        {
            _path = arquivo;
        }

        public string Read(string section, string key)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", RetVal, 255, _path);
            return RetVal.ToString();
        }

        private static void IniExiste(string section, string key, string value, string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                Write(section, key, "", path);
            }
        }

        public static string Read(string section, string key, string path = "Configuracao\\Config.ini")
        {
            var RetVal = new StringBuilder(999);
            GetPrivateProfileString(section, key, "", RetVal, 999, path);
            return RetVal.ToString();
        }

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, _path);
        }

        public static void Write(string section, string key, string value, string path = "Configuracao\\Config.ini")
        {
            WritePrivateProfileString(section, key, value, path);
        }

        public void DeleteKey(string section, string key)
        {
            Write(section, key, null);
        }

        public void DeleteSection(string section)
        {
            Write(section, null, null);
        }

        public bool KeyExists(string section, string key)
        {
            return Read(section, key).Length > 0;
        }

    }
}
