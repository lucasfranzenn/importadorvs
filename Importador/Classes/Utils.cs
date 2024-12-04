using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.Properties;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Data;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using static Importador.Classes.Constantes;

namespace Importador.Classes
{
    public class Utils
    {
        public static void AlteraAba(ref FluentDesignFormContainer container, XtraUserControl userControl)
        {
            container.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            container.Controls.Add(userControl);
        }

        public static void MostrarNotificacao(string msg, string titulo)
        {
            new ToastContentBuilder()
                .AddText(titulo)
                .AddText(msg)
                .Show();
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
            StringBuilder cmd = new(Caminhos.exeMySqlDump);

            var Conexao = ConexaoBancoImportador.GetEntidade<Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 0");
            var Tabelas = ConexaoBancoImportador.GetSql(Enums.TabelaMyCommerce.backup.ToString());
            cmd.Append($" -u {Conexao.Usuario} -p{Conexao.Senha} -h {Conexao.Host} -P {Conexao.Porta} {Conexao.Banco} {tabelas} > \"MyBackup.sql\"");

            return cmd.ToString();
        }


        internal static AutoCompleteStringCollection GetAutoCompleteCustomSource(IDbCommand cmd)
        {
            var reader = cmd.ExecuteReader();
            AutoCompleteStringCollection acsc = new();

            while (reader.Read())
            {
                acsc.Add(reader.GetString(0));
            }

            return acsc;
        }

        public static Entidades.Conexao GetImportacao(Enums.Sistema sistema) => sistema switch
        {
            Enums.Sistema.MyCommerce => ConexaoBancoImportador.GetEntidade<Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 0"),
            _ => ConexaoBancoImportador.GetEntidade<Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 1 and Padrao = 1")
        };

        internal static string GetUsuarioSID() => WindowsIdentity.GetCurrent().User.ToString();
        internal static string GetSqlPadrao(string tabela) => SQLPadrao.Default[tabela].ToString().Replace("@", Environment.NewLine);
        internal static string GerarArquivoRar(string caminhoBackup) => $"\"{AppDomain.CurrentDomain.BaseDirectory}{Caminhos.exeRar}\" a -ep \"{caminhoBackup}\" \"MyBackup.sql\" \"Relatorios\\Implantação {Configuracoes.Default.CodigoImplantacao}.pdf\" \"LEIA-ME.txt\"";

        internal static void GerarLeiaME(string sql)
        {
            string conteudo = $"O script dentro desse arquivo contém informações das seguintes tabelas:\n`{sql.Replace(" ", "`, `")}`\n\nQualquer informação que esteja em uma das tabelas dessa lista será subscrita pelos dados do script.";

            File.WriteAllText("LEIA-ME.txt", conteudo);
        }
    }

}
