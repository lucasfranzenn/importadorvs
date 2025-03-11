using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using DevExpress.Office.Crypto;
using Importador.UserControls.BaseControls;

namespace Importador.Formularios
{
    public partial class frmOpcoes : DevExpress.XtraEditors.DirectXForm
    {
        public frmOpcoes()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            Close();
        }

        private void aceAmbienteGeral_Click(object sender, EventArgs e)
        {
            Classes.Utils.AlteraAba(ref pnlPrincipal, new UserControls.Opcoes.UCAmbienteGeral());
        }

        private void pnlPrincipal_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control is UCBaseOpcao controle)
            {
                controle.SalvarConfig();
            }
        }

        private void frmOpcoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnSair_Click(sender, e);
        }

        private void aceIntegracoesGoogleDrive_Click(object sender, EventArgs e)
        {
            Classes.Utils.AlteraAba(ref pnlPrincipal, new UserControls.Opcoes.UCIntegracaoGoogleDrive());
        }

        private void aceIntegracoesJira_Click(object sender, EventArgs e)
        {
            Classes.Utils.AlteraAba(ref pnlPrincipal, new UserControls.Opcoes.UCIntegracaoJira());
        }
    }
}