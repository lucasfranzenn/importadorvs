﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace Importador.User_Controls
{
    public partial class UCExportarDados : DevExpress.XtraEditors.XtraUserControl
    {
        public UCExportarDados()
        {
            InitializeComponent();
        }

        private void rbBancoImp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Consultas SQL", "exportarSqlCsv.py");
            string connectionString = "Driver={MySQL ODBC 8.0 Driver};Server=10.1.1.220;Port=3306;Database=bdvinicius;User=root;Password=vssql;Option=3;";
            string query = meSql.Text;
            string outputCsvPath = Path.Combine(txtCaminhoFinal.Text, "output.csv");

            ExecutePythonScript(scriptPath, connectionString, query, outputCsvPath);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoFinal.Text = xtraFolderBrowserDialog1.SelectedPath;
            }
        }

        public void ExecutePythonScript(string scriptPath, string connectionString, string query, string outputCsvPath)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "python"; // ou "python3" dependendo da instalação

            // Colocando o caminho do script entre aspas
            start.Arguments = $"\"{scriptPath}\" \"{connectionString}\" \"{query}\" \"{outputCsvPath}\"";

            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.CreateNoWindow = true;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    MessageBox.Show(result);
                }

                using (StreamReader reader = process.StandardError)
                {
                    string error = reader.ReadToEnd();
                    MessageBox.Show(error);
                }
            }
        }

    }
}