using Importador.Classes;
using System;

namespace Importador.User_Controls
{
    public partial class UCClientes : DevExpress.XtraEditors.XtraUserControl
    {
        public UCClientes()
        {
            InitializeComponent();
        }

        private void UCClientes_Load(object sender, EventArgs e)
        {
            txtSqlImportacao.Text = ConsultasJSON.GetSql("clientes");
        }
    }
}
