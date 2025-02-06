using DevExpress.Mvvm.Native;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.Properties;
using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json;
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
        internal static string GetSqlPadrao(string tabela)
        {
            Dictionary<string, string> consultas = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(Constantes.Caminhos.SqlPadroes)) ?? new Dictionary<string, string>();

            if (consultas.TryGetValue(tabela, out string sql)) return sql.Replace("@", Environment.NewLine);

            return SQLPadrao.Default[tabela].ToString().Replace("@", Environment.NewLine);
        }

        internal static string GerarArquivoRar(string caminhoBackup) => $"\"{AppDomain.CurrentDomain.BaseDirectory}{Caminhos.exeRar}\" a \"{caminhoBackup}\" \"MyBackup.sql\" \"Relatorios\\Implantação {Configuracoes.Default.CodigoImplantacao}.pdf\" \"Consultas SQL\\*\" \"LEIA-ME.txt\" ";

        internal static void GerarLeiaME(string sql)
        {
            string conteudo = $"O script dentro desse arquivo contém informações das seguintes tabelas:\n`{sql.Replace(" ", "`, `")}`\n\nQualquer informação que esteja em uma das tabelas dessa lista será subscrita pelos dados do script.\nCaso seja necessário que os dados que estão no banco do cliente não sejam subscritos, deverá ser informado previamente.\nSe já foi informado essa necessidade, por favor, ignore esta mensagem.";

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
            Directory.GetFiles("Consultas SQL").ForEach(file => File.Delete(file));

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

            for (int i = 0; i < cabecalhos.Length; i++)
            {
                columnWidths[i] = cabecalhos[i].Length;
            }

            foreach (string[] reg in listaRegistros)
            {
                string[] row = new string[cabecalhos.Length];
                for (int i = 0; i < cabecalhos.Length; i++)
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
            if (value is DBNull || string.IsNullOrEmpty(value.ToString())) return DBNull.Value;

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
                        if (v.Length > tamCol) return v.Substring(0, tamCol);
                    }

                    return value;
            }
        }

        internal static void GerarComoUsar()
        {
            string conteudo="Para utilizar os arquivos de validações, recomenda-se seguir o seguinte processo:\n\t1. Verificar o arquivo \"log_validacoes\" para verificar o que está errado.\n\t2. Verificar nos outros arquivos o porquê está errado.\n\t3. Verificar o que seria o certo com o cliente.\n\nTabela de LOGS\n";
            var listaRegistros = new List<string[]>
            {
                new string[] { "log_validacoes", "Contém todo o processo que rolou durante as validações e quantos registros estão errados." },
                new string[] { "ncm_inválidos", "Contém todos os produtos que não tem NCM cadastrado (É obrigatório que todo produto possua um NCM cadastrado)." },
                new string[] { "cest_inválidos", "Contém todos os produtos com cest errado ou não cadastrado (Quando o produto tiver NCM e esse NCM possuir CEST, é obrigatório que esteja cadastrado no produto)." },
                new string[] { "cpfcnpj_duplicado", "Contém todos os clientes que estão com CPF ou CNPJ duplicado, isto é, quando houver mais de um cliente/fornecedor com o mesmo CPF/CNPJ" },
                new string[] { "codibge_inválidos", "Contém todos os clientes que estão com o cadastro do codibge errado (Quando estiver errado, ocorrerá problemas ao faturar notas)." },
                new string[] { "contasquitadas_pendentes", "Contém todas as contas que estão marcadas como quitadas, porém ainda mostram que existem valores pendentes a serem pagos (Se uma conta está quitada, não pode haver valores pendentes)." },
                new string[] { "produtos_fiscal", "Contém todos os produtos que estão com erros fiscais de acordo com o arquivo de importação fiscal." },
            };
            string rodape = "\nOBSERVAÇÕES\n**Lembrando que essas são as regras de negócio do ERP MyCommerce, nos outros Sistemas algumas dessas regras podem ser diferentes ou não existem.\n**As validações servem para apontar oque está errado/faltando para que possa ser corrigido e o cliente funcionar da melhor maneira possível.\n**Geralmente não é enviado o log de contasquitadas_pendentes pois é corrigido na própria importação, salvo raríssimas exceções.";

            CriarTXT(conteudo + ExportRegToText(["Arquivo LOG", "Pra que serve"], listaRegistros) + rodape, $"Validacoes\\COMO USAR");
        }

        internal static string LerArquivo(string caminho)
        {
            string nomeDiretorio = Path.GetDirectoryName(caminho);

            if (!Path.Exists(nomeDiretorio) || !File.Exists(caminho))
            {
                return string.Empty;
            }

            return File.ReadAllText(caminho);
        }
    }

}