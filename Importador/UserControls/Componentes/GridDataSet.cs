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

        private void btnExportarRegistros_CheckedChanged(object sender, EventArgs e)
        {
            if(Utils.SalvarArquivo($"registros_exportados", "Arquivo de texto|*.txt|Planilha Excel|*.xls") is string caminho)
            {
                if (Path.GetExtension(caminho) == ".txt")
                {
                    Utils.CriarTXT(Utils.ExportSQLtoText(_cmd), caminho);
                }else if(Path.GetExtension(caminho) == ".xls"){
                    Utils.CriarXLS(Utils.GetDataTable(_cmd), caminho);
                }
            }
        }
    }
}
