using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.UserControls.BaseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
