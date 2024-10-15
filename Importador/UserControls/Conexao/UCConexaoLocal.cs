using Importador.UserControls.BaseControls;
using System;
using static Importador.Classes.Constantes.Enums;
using System.Windows.Forms;
using static Importador.Properties.Configuracoes;

namespace Importador.UserControls.Conexao
{
    public partial class UCConexaoLocal : UCBase
    {
        public UCConexaoLocal()
        {
            InitializeComponent();
        }

        private void UCConexaoLocal_Load(object sender, EventArgs e)
        {
            txtCaminhoBanco.Text = Default.BancoLocal;
        }

        private void UCConexaoLocal_Leave(object sender, EventArgs e)
        {
            Default.BancoLocal = txtCaminhoBanco.Text;
            Default.Save();
        }

        private void txtCaminhoBanco_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Banco SQLite|*.db";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCaminhoBanco.Text = ofd.FileName;
                }
            }
        }
    }
}
