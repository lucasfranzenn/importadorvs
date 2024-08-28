using DevExpress.XtraMap;
using Importador.Classes;
using Importador.Classes.JSON;
using Importador.Conexao;
using System;
using System.Data;

namespace Importador.User_Controls
{
    public partial class UCClientes : UCImportacaoBase
    {
        public UCClientes()
        {
            InitializeComponent();
        }

        private void UCClientes_Load(object sender, EventArgs e)
        {
            if (ConexaoManager.ConexoesAbertas())
            {
                txtSqlImportacao.Text = ConsultasJSON.GetSql("clientes");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Conexões não foram estabelecidas!\nConfigure-as corretamente", "..::Importador::..");
                Enabled = false;
            }


        }
    }
}
