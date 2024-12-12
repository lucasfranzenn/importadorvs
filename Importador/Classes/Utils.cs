using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.Properties;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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
        internal static string GerarArquivoRar(string caminhoBackup) => $"\"{AppDomain.CurrentDomain.BaseDirectory}{Caminhos.exeRar}\" a \"{caminhoBackup}\" \"MyBackup.sql\" \"Relatorios\\Implantação {Configuracoes.Default.CodigoImplantacao}.pdf\" \"Consultas SQL\\*\" \"LEIA-ME.txt\" ";

        internal static void GerarLeiaME(string sql)
        {
            string conteudo = $"O script dentro desse arquivo contém informações das seguintes tabelas:\n`{sql.Replace(" ", "`, `")}`\n\nQualquer informação que esteja em uma das tabelas dessa lista será subscrita pelos dados do script.";

            File.WriteAllText("LEIA-ME.txt", conteudo);
        }

        internal static void CriarTXT(string conteudo, string caminho)
        {
            string nomeDiretorio = Path.GetDirectoryName(caminho);

            if (!Path.Exists(nomeDiretorio))
            {
                Directory.CreateDirectory(nomeDiretorio);
            }

            caminho = Path.ChangeExtension(caminho, ".txt");

            File.WriteAllText(caminho, conteudo);
        }

        internal static string ExportSQLtoText(string consulta)
        {
            StringBuilder conteudo = new();
            string value;

            IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CreateCommand();
            cmd.CommandText = consulta;

            using IDataReader reader = cmd.ExecuteReader();

            int[] columnWidths = new int[reader.FieldCount];
            List<string[]> rows = new();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                columnWidths[i] = reader.GetName(i).Length; 
            }

            while (reader.Read())
            {
                string[] row = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    value = reader[i] is DBNull ? "null" : reader[i].ToString();
                    row[i] = value;
                    columnWidths[i] = Math.Max(columnWidths[i], value.Length);
                }
                rows.Add(row);
            }

            conteudo.Append('-');
            for (int i = 0; i < reader.FieldCount; i++)
            {
                conteudo.Append(new string('-', columnWidths[i]) + "--");
            }
            conteudo.AppendLine();

            // Escrever cabeçalhos
            conteudo.Append('|');
            for (int i = 0; i < reader.FieldCount; i++)
            {
                conteudo.Append(reader.GetName(i).PadRight(columnWidths[i] + 2));
                conteudo.Remove(conteudo.Length - 1, 1);
                conteudo.Append('|');
            }
            conteudo.AppendLine();


            conteudo.Append('|');
            for (int i = 0; i < reader.FieldCount; i++)
            {
                conteudo.Append(new string('-', columnWidths[i]) + "-|");
            }
            conteudo.AppendLine();

            foreach (var row in rows)
            {
                conteudo.Append('|');
                for (int i = 0; i < row.Length; i++)
                {
                    conteudo.Append(row[i].PadRight(columnWidths[i] + 2));
                    conteudo.Remove(conteudo.Length - 1, 1);
                    conteudo.Append('|');
                }
                conteudo.AppendLine();
            }

            conteudo.Append('-');
            for (int i = 0; i < reader.FieldCount; i++)
            {
                conteudo.Append(new string('-', columnWidths[i]) + "--");
            }
            conteudo.AppendLine();

            conteudo.Append($"\nPara obter os registros acima, foi utilizado a seguinte consulta sql:\n\t{consulta}");

            return conteudo.ToString();
        }

        internal static void DeletarArquivo(string arquivo)
        {
            if (File.Exists(arquivo)) { File.Delete(arquivo); }
        }

        internal static void GerarArquivosConsultaSQL()
        {
            IDbCommand cmd = ConexaoBancoImportador.instancia.conexao.CriarComando();

            cmd.CommandText = $"select 'Consultas SQL\\' || tabelaconsulta, consulta from consultas where codigoimplantacao ={Configuracoes.Default.CodigoImplantacao} and tabelaconsulta <> 'backup'";
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CriarTXT(reader[1].ToString(), reader[0].ToString());
            }
            reader.Close();
        }

        internal static string ExportRegToText(string[] cabecalhos, List<string[]> listaRegistros)
        {
            StringBuilder conteudo = new();

            int[] columnWidths = new int[cabecalhos.Length];
            List<string[]> rows = new();
            string value;

            for(int i = 0; i < cabecalhos.Length; i++)
            {
                columnWidths[i] = cabecalhos[i].Length;
            }

            foreach(string[] reg in listaRegistros)
            {
                string[] row = new string[cabecalhos.Length];
                for(int i = 0; i < cabecalhos.Length;i++)
                {
                    value = reg[i].ToString();
                    row[i] = value;
                    columnWidths[i] = Math.Max(columnWidths[i], value.Length);
                }
                rows.Add(row);
            }

            conteudo.Append('-');
            for (int i = 0; i < cabecalhos.Length; i++)
            {
                conteudo.Append(new string('-', columnWidths[i]) + "--");
            }
            conteudo.AppendLine();

            // Escrever cabeçalhos
            conteudo.Append('|');
            for (int i = 0; i < cabecalhos.Length; i++)
            {
                conteudo.Append(cabecalhos[i].PadRight(columnWidths[i] + 2));
                conteudo.Remove(conteudo.Length - 1, 1);
                conteudo.Append('|');
            }
            conteudo.AppendLine();


            conteudo.Append('|');
            for (int i = 0; i < cabecalhos.Length; i++)
            {
                conteudo.Append(new string('-', columnWidths[i]) + "-|");
            }
            conteudo.AppendLine();

            foreach (var row in rows)
            {
                conteudo.Append('|');
                for (int i = 0; i < row.Length; i++)
                {
                    conteudo.Append(row[i].PadRight(columnWidths[i] + 2));
                    conteudo.Remove(conteudo.Length - 1, 1);
                    conteudo.Append('|');
                }
                conteudo.AppendLine();
            }

            conteudo.Append('-');
            for (int i = 0; i < cabecalhos.Length; i++)
            {
                conteudo.Append(new string('-', columnWidths[i]) + "--");
            }
            conteudo.AppendLine();

            return conteudo.ToString();
        }

        public static object CastDataType(string dataType, object value, int tamCol = 9999)
        {
            if (value is DBNull) return DBNull.Value;

            switch (dataType)
            {
                case "int":
                    return Convert.ToInt32(value);
                case "double":
                    return Convert.ToDouble(value);
                case "date" or "datetime":
                    return value;
                default:
                    if (value is string v)
                    {
                        if (string.IsNullOrEmpty(v)) return DBNull.Value;
                        if (v.Length > tamCol) return v.Substring(0, tamCol);
                    }

                    return value;
            }
        }
    }

}