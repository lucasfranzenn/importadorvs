using Importador.Classes;
using Importador.Conexao;
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
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            txtSqlImportacao.Text = ConsultasJSON.GetSql("clientes");
        }
    }
}
