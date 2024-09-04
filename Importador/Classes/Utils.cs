﻿using DevExpress.Mvvm.Native;
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
using static Importador.Classes.VariaveisGlobais;
using DevExpress.LookAndFeel;

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
        public static void SetConexoesJson(ConexoesJson conexoesJson) => File.WriteAllText(PathConexoesJson, conexoesJson.ToJson());
        public static void SalvarSkin(string skinName, string skinPalette) => File.WriteAllText(PathSkinTxt, skinName + "," + skinPalette);

        public static void MostrarNotificacao(string msg, string titulo)
        {
            new ToastContentBuilder()
                .AddText(titulo)
                .AddText(msg)
                .Show();
        }

        public static void CarregaSkin(ref DefaultLookAndFeel skin)
        {
            skin.LookAndFeel.SetSkinStyle(File.ReadAllText(PathSkinTxt).Split(',')[0], File.ReadAllText(PathSkinTxt).Split(',')[1]);
            skin.LookAndFeel.UseDefaultLookAndFeel = true;
        }
    }

}
