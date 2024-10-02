using DevExpress.Mvvm.Native;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
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
using Importador.Properties;
using Importador.Classes.Entidades;

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

        public static Entidades.Conexao GetImportacao(Enums.Sistema sistema) => sistema switch
        {
            Enums.Sistema.MyCommerce => ConexaoBancoImportador.GetEntidade<Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 0"),
            _ => ConexaoBancoImportador.GetEntidade<Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 1 and Padrao = 1")
        };

        public static void MostrarNotificacao(string msg, string titulo)
        {
            new ToastContentBuilder()
                .AddText(titulo)
                .AddText(msg)
                .Show();
        }

        internal static string GetSqlPadrao(string tabela)
        {
            return SQLPadrao.Default[tabela].ToString().Replace("@", Environment.NewLine);
        }

        internal static void AtualizaSQLImportacao(string sql, Enums.TabelaMyCommerce tabela)
        {
            try
            {
                var Consulta = ConexaoBancoImportador.GetEntidade<Consultas>(Enums.TabelaBancoLocal.consultas, $"TabelaConsulta = '{tabela.ToString()}'");
                Consulta.Consulta = sql;
                ConexaoBancoImportador.Update(Consulta, Enums.TabelaBancoLocal.consultas);
            }
            catch (Exception)
            {
                ConexaoBancoImportador.InserirRegistro(new Consultas(tabela.ToString(), sql), Enums.TabelaBancoLocal.consultas);
            }
        }
    }

}
