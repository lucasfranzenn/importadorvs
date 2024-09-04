using DevExpress.Mvvm.Native;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using Importador.Classes.JSON;
using Importador.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;
using static Importador.Classes.Constantes;
using DevExpress.LookAndFeel;
using DevExpress.Charts.Native;

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

        public static Importacao GetImportacao(Enums.Sistema sistema) => sistema switch
        {
            Enums.Sistema.MyCommerce => ConexoesJson.FromJson(File.ReadAllText(Caminhos.ConexoesJson)).Mycommerce,
            _ => ConexoesJson.FromJson(File.ReadAllText(Caminhos.ConexoesJson)).Importacao
        };

        public static ConexoesJson GetConexoesJson() => ConexoesJson.FromJson(File.ReadAllText(Caminhos.ConexoesJson));
        public static void SetConexoesJson(ConexoesJson conexoesJson) => File.WriteAllText(Caminhos.ConexoesJson, conexoesJson.ToJson());
        public static void SalvarSkin(string skinName, string skinPalette) => File.WriteAllText(Caminhos.SkinTxt, skinName + "," + skinPalette);

        public static void MostrarNotificacao(string msg, string titulo)
        {
            new ToastContentBuilder()
                .AddText(titulo)
                .AddText(msg)
                .Show();
        }

        public static void CarregaSkin(ref DefaultLookAndFeel skin)
        {
            skin.LookAndFeel.SetSkinStyle(File.ReadAllText(Caminhos.SkinTxt).Split(',')[0], File.ReadAllText(Caminhos.SkinTxt).Split(',')[1]);
            skin.LookAndFeel.UseDefaultLookAndFeel = true;
        }
    }

}
