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
using Importador.Classes.JSON;

namespace Importador.UserControls.Importacao
{
    public partial class UCProdutos : UserControls.BaseControls.UCBaseImportacao
    {
        public UCProdutos()
        {
            InitializeComponent();
        }

        private void UCProdutos_Load(object sender, EventArgs e)
        {
            txtSqlImportacao.Text = ConsultasJSON.GetSql("produtos");
        }
    }
}
