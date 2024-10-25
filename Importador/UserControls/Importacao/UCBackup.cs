using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Conexao;
using Importador.Properties;
using Importador.UserControls.BaseControls;
using Importador.UserControls.Componentes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            ofd.InitialDirectory = Path.GetDirectoryName(txtDestinoBackup.Text);
            ofd.FileName = Path.GetFileName(txtDestinoBackup.Text);
            ofd.Filter = "Backup|*.rar";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDestinoBackup.Text = ofd.FileName;
            }
        }

        private void UCBackup_Load(object sender, EventArgs e)
        {
            if (!ConexaoManager.ConexoesAbertas())
            {
                Enabled = false;
                return;
            }

            txtDestinoBackup.Text = $"C:\\Implantação {Configuracoes.Default.CodigoImplantacao} - {DateTime.Now.ToString("ddMMyyyy HHmm")}.rar";

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

            if (ConexaoBancoImportador.ExisteObservacao("backup")) { btnObservacao.ImageOptions.Image = Resources.newtask_16x16; }
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
            if (gcGridTabelas.MainView is DevExpress.XtraGrid.Views.Grid.GridView gv1)
            {
                gv1.ClearGrouping();
            }

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

                executarMySqlDump.Kill();

                Process executarRar = new Process()
                {
                    StartInfo =
                    {
                        WindowStyle= ProcessWindowStyle.Hidden,
                        FileName = "cmd.exe",
                        Arguments = $"/C \"{Utils.GerarArquivoRar(txtDestinoBackup.Text)}",
                        UseShellExecute = false
                    }
                };

                executarRar.Start();
                executarRar.WaitForExit();
                File.Delete("MyBackup.sql");

                if (XtraMessageBox.Show("Backup Gerado\nDeseja abrir a pasta de destino?", "..::Importador::..", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void btnObservacao_Click(object sender, EventArgs e)
        {
            var obsObservacao = new Observacao(btnObservacao.Location, Size, "backup");

            AlternarVisibilidade();
            Controls.Add(obsObservacao);

            obsObservacao.BringToFront();

            obsObservacao.Disposed += (sender, args) => AlternarVisibilidade();
            SizeChanged -= (sender, args) => obsObservacao.AtualizaProporcoes(btnObservacao.Location, Size);
            SizeChanged += (sender, args) => obsObservacao.AtualizaProporcoes(btnObservacao.Location, Size);
        }

        private void AlternarVisibilidade()
        {
            Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = !c.Enabled);
        }
    }
}
