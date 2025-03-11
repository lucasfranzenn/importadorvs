using DevExpress.Utils.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.Diagnostics;
using Importador.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importador.UserControls.Utilitarios
{
    public partial class UCPython : BaseControls.UCBase
    {
        string pythonFolder = @"\\Python";
        DataTable dt;

        public UCPython()
        {
            InitializeComponent();
        }

        private void UCPython_Load(object sender, EventArgs e)
        {
            pythonFolder = IniFile.Read("AmbienteGeral", "PythonFolderPath");

            if (!Path.Exists(pythonFolder))
            {
                XtraMessageBox.Show("Pasta de Scripts Python não existe!\nConfigure-a corretamente", "..::Importador::..");
                return;
            }

            FormataGrid();
            CarregarArquivos();
        }

        private void FormataGrid()
        {
            dt = new();
            dt.Columns.Add("Arquivo", typeof(string));
            dt.Columns.Add("Argumentos", typeof(string));
            dt.Columns.Add("Executar", typeof(string));

            gcArquivosPython.DataSource = dt;
            gvMain.Columns["Executar"].ColumnEdit = new RepositoryItemButtonEdit
            {
                Buttons = { [0] = { Caption = "Executar", Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph } },
                TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            };

            gvMain.CustomRowCellEdit += (sender, e) => { if (e.Column.FieldName == "Executar") { e.RepositoryItem = gvMain.Columns["Executar"].ColumnEdit; } };
            gvMain.Columns["Executar"].ColumnEdit.Click += gvMain_ButtonClick;
        }

        private void gvMain_ButtonClick(object sender, EventArgs e)
        {
            int index = gvMain.FocusedRowHandle;
            string arquivo = dt.Rows[index][0].ToString(); //Pega o nome do arquivo .py
            string argumentos = dt.Rows[index][1].ToString(); //Pega os argumentos a serem passados

            ExecutarScriptPython(Path.Combine(pythonFolder, arquivo), argumentos);

        }

        private void ExecutarScriptPython(string caminho, string argumentos)
        {
            bool waitingInput = false;
            txtLog.Clear();

            ProcessStartInfo psi = new ProcessStartInfo
            {
                WorkingDirectory=Path.GetDirectoryName(caminho),
                FileName = "cmd.exe",
                Arguments = $"/C python {Path.GetFileName(caminho)} {argumentos}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            Process process = new Process { StartInfo = psi };

            process.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {

                    if (e.Data.Contains("###WAITING_INPUT###"))
                    {
                        txtLog.AppendText("[IMPORTADOR] Input:");
                        txtLog.SelectionStart = txtLog.Text.Length;
                        waitingInput = true;
                        txtLog.Properties.ReadOnly = false;
                    }else if (e.Data.Contains("###ENDED###"))
                    {
                        txtLog.AppendText("[IMPORTADOR] Script Finalizado!");
                        process.Kill();
                    }
                    else
                    {
                        txtLog.Invoke(new Action(() => txtLog.AppendText("[PYTHON] " + e.Data + Environment.NewLine)));
                    }
                }
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    txtLog.Invoke(new Action(() => txtLog.AppendText("ERROR: " + e.Data + Environment.NewLine)));
                }
            };

            txtLog.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter && waitingInput)
                {
                    e.SuppressKeyPress = true;
                    string input = txtLog.Lines.LastOrDefault()?.ToString();
                    input = input.Substring(19) ?? "";

                    process.StandardInput.Flush();
                    process.StandardInput.WriteLine(input);
                    process.StandardInput.Flush();
                    txtLog.AppendLine("nl\r\n");
                    waitingInput = false; 
                    txtLog.Properties.ReadOnly = true;
                    
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

        }

        private void CarregarArquivos()
        {
            string[] arquivos = Directory.GetFiles(pythonFolder, "*.py");

            foreach (var arquivo in arquivos)
            {
                dt.Rows.Add(Path.GetFileName(arquivo), "", "Executar");
            }

        }
    }
}
