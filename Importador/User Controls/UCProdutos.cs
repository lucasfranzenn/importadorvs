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

namespace Importador.User_Controls
{
    public partial class UCProdutos : DevExpress.XtraEditors.XtraUserControl
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
