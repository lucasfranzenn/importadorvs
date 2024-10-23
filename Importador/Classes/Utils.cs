using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.Properties;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Text;
using static Importador.Classes.Constantes;

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

        internal static void AtualizaSQLImportacao(string sql, string tabela)
        {
            var Consulta = ConexaoBancoImportador.GetEntidade<Consultas>(Enums.TabelaBancoLocal.consultas, $"TabelaConsulta = '{tabela}'");

            if (Consulta is null)
            {
                ConexaoBancoImportador.InserirRegistro(new Consultas(tabela, sql), Enums.TabelaBancoLocal.consultas);
                return;
            }

            Consulta.Consulta = sql;
            ConexaoBancoImportador.Update(Consulta, Enums.TabelaBancoLocal.consultas);
        }

        public static string GetCmdDump(string tabelas, string caminhoBackup)
        {
            StringBuilder cmd = new(Caminhos.mysqlDump);

            var Conexao = ConexaoBancoImportador.GetEntidade<Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 0");
            var Tabelas = ConexaoBancoImportador.GetSql(Enums.TabelaMyCommerce.backup.ToString());
            cmd.Append($" -u {Conexao.Usuario} -p{Conexao.Senha} -h {Conexao.Host} -P {Conexao.Porta} {Conexao.Banco} {tabelas} > \"MyBackup.sql\"");

            return cmd.ToString();
        }

        internal static string GerarArquivoRar(string caminhoBackup)
        {
            return $"\"{AppDomain.CurrentDomain.BaseDirectory}{Caminhos.rar}\" a \"{caminhoBackup}\" \"MyBackup.sql\"";
        }
    }

}
