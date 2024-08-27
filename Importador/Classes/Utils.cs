using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using Importador.Classes.JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Importador.Classes.VariaveisGlobais;

namespace Importador.Classes
{
    public class Utils
    {
        public static void AlteraAba(ref FluentDesignFormContainer container, XtraUserControl userControl)
        {
            container.Controls.Clear();
            userControl.Dock = System.Windows.Forms.DockStyle.Fill;
            container.Controls.Add(userControl);
        }

        public static Importacao GetImportacao(Sistema sistema) => sistema switch
        {
            Sistema.MyCommerce => ConexoesJson.FromJson(File.ReadAllText(PathConexoesJson)).Mycommerce,
            _ => ConexoesJson.FromJson(File.ReadAllText(PathConexoesJson)).Importacao
        };

        public static ConexoesJson GetConexoesJson() => ConexoesJson.FromJson(File.ReadAllText(PathConexoesJson));
        public static void SetConexoesJson(ConexoesJson conexoesJson) => File.WriteAllText(PathConexoesJson, ConexoesSerialize.ToJson(conexoesJson));
        public static void SalvarSkin(string skinName, string skinPalette) => File.WriteAllText(PathSkinTxt, skinName + "," + skinPalette);
    }

}
