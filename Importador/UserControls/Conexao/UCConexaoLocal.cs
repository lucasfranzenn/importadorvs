using Importador.UserControls.BaseControls;
using System;
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
    }
}
