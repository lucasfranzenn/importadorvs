﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Importador.UserControls.BaseControls;
using Importador.Classes;
using System.Windows.Controls;
using Importador.Conexao;
using Importador.Classes.Entidades;
using System.Diagnostics;
using Importador.Properties;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Mvvm.Native;

namespace Importador.UserControls.Importacao
{
    public partial class UCBackup : UCBase
    {
        public UCBackup()
        {
            InitializeComponent();
        }

        private void txtDestinoBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SalvarArquivo();
            }
        }

        private void SalvarArquivo()
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.FileName = Path.GetFileName(txtDestinoBackup.Text);
            ofd.Filter = "Backup|.sql";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDestinoBackup.Text = ofd.FileName;
            }
        }

        private void UCBackup_Load(object sender, EventArgs e)
        {
            if (!ConexaoManager.ConexoesAbertas())
            {
                XtraMessageBox.Show("Conexões não foram estabelecidas!\nConfigure-as corretamente", "..::Importador::..");
                Enabled = false;
                return;
            }

            txtDestinoBackup.Text = $"C:\\Implantação {Configuracoes.Default.CodigoImplantacao} - {DateTime.Now.ToString("ddMMyyyy HHmm")}.sql";

            IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CreateCommand();
            cmd.CommandText = "show tables";

            using IDataReader reader = cmd.ExecuteReader();
                DataTable dt = new();
                dt.Load(reader, LoadOption.PreserveChanges);
                dt.Columns[0].ColumnName = "Tabelas";

                DataColumn checkColumn = new DataColumn("Restaurar?", typeof(bool));
                checkColumn.DefaultValue = false;
                dt.Columns.Add(checkColumn);

                gcGridTabelas.DataSource = dt;

            if (gcGridTabelas.MainView is DevExpress.XtraGrid.Views.Grid.GridView gridView)
            {
                gridView.Columns[0].OptionsColumn.AllowEdit = false;
                gridView.BestFitColumns();
            }

            MarcarTabelas();
        }

        private void MarcarTabelas()
        {
            List<string> tabelasParaMarcar = ConexaoBancoImportador.GetSql("backup").Split(" ").ToList();

            if (gcGridTabelas.MainView is DevExpress.XtraGrid.Views.Grid.GridView gridView)
            {
                string nomeTabela;
                bool tabelaEstaMarcada;
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    nomeTabela = gridView.GetRowCellValue(i, "Tabelas").ToString();

                    tabelaEstaMarcada = tabelasParaMarcar.Contains(nomeTabela);
                    gridView.SetRowCellValue(i, "Restaurar?", tabelaEstaMarcada);
                }
            }
        }

        private void btnGerarBackup_Click(object sender, EventArgs e)
        {
            string sql = PegarTabelasMarcadas();

            Utils.AtualizaSQLImportacao(sql, "backup");

            string comandoMySqlDump = Utils.GetCmdDump(sql, txtDestinoBackup.Text);

            try
            {
                Process executarMySqlDump = new Process()
                {
                    StartInfo =
                    {
                        WindowStyle = ProcessWindowStyle.Hidden,
                        FileName = "cmd.exe",
                        Arguments = "/C \"" + comandoMySqlDump + "\"",
                        UseShellExecute = false
                    }
                };

                executarMySqlDump.Start();

                executarMySqlDump.WaitForExit();

                if (XtraMessageBox.Show("Backup Gerado", "..::Importador::..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Process.Start("explorer.exe", $"/select, {txtDestinoBackup.Text}");
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private string PegarTabelasMarcadas()
        {
            List<string> tabelasMarcadas = new List<string>();

            if (gcGridTabelas.MainView is DevExpress.XtraGrid.Views.Grid.GridView gridView)
            {
                Enumerable.Range(0, gridView.RowCount)
                                    .Where(i => (bool)gridView.GetRowCellValue(i, "Restaurar?"))
                                    .ToList()
                                    .ForEach(i => tabelasMarcadas.Add(gridView.GetRowCellValue(i, "Tabelas").ToString()));
            }

            return string.Join(" ", tabelasMarcadas);
        }

        private void btnSelecionarDestino_CheckedChanged(object sender, EventArgs e)
        {
            SalvarArquivo();
        }
    }
}
