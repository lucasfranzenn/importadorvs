using DevExpress.XtraEditors;
using Importador.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importador.UserControls.Auxiliar
{
    public partial class UCFiscal : DevExpress.XtraEditors.XtraUserControl
    {
        public UCFiscal()
        {
            InitializeComponent();
        }

        private void pdfViewer_Load(object sender, EventArgs e)
        {
            pdfViewer.DocumentFilePath = Constantes.Caminhos.pdfImportacaoFiscal;
        }
    }
}
