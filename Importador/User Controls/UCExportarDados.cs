using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoFinal.Text = xtraFolderBrowserDialog1.SelectedPath;
            }
        }
    }
}
