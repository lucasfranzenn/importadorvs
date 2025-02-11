using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using Importador.Classes;
using Importador.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Importador.Classes.Utils;

namespace Importador.UserControls.Componentes
{
    public partial class GridDataSet : DevExpress.XtraEditors.XtraUserControl
    {
        private string _cmd = "";

        public GridDataSet()
        {
            InitializeComponent();
        }

        public GridDataSet(IDbCommand cmd)
        {
            InitializeComponent();
            gcRegistros.DataSource = null;
            _cmd = cmd.CommandText;

            gridView1.Columns.Clear();
            gridView1.OptionsView.ColumnAutoWidth = false;
            DataTable dt = new DataTable();

            using IDataReader reader = cmd.ExecuteReader();
                dt.Load(reader, LoadOption.OverwriteChanges);
                gcRegistros.DataSource = dt;

            Dock = DockStyle.Fill;

            lblQtdeLinhas.Text = dt.Rows.Count.ToString();
        }

        private async void btnExportarRegistros_CheckedChanged(object sender, EventArgs e)
        {
            if(Utils.SalvarArquivo($"registros_exportados", "Arquivo de texto|*.txt|Planilha Excel|*.xlsx") is string caminho)
            {
                if (Path.GetExtension(caminho) == ".txt")
                {
                    await Task.Run(()=>CriarTXT(Utils.ExportSQLtoText(_cmd), caminho));
                }else if(Path.GetExtension(caminho) == ".xlsx"){
                    await Task.Run(()=>CriarXLSX(Utils.GetDataTable(_cmd), caminho));
                }

                Utils.MostrarNotificacao($"Arquivo {Path.GetFileName(caminho)} exportado!", "Exportação de Arquivos");

                if (XtraMessageBox.Show("Arquivo Gerado\nDeseja abrir a pasta de destino?", "..::Importador::..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Utils.AbrirPastaDestino(caminho);
            }
        }
    }
}
