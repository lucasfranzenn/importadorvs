using Importador.User_Controls;
using System;
using static Importador.Classes.Utils;

namespace Importador
{
    public partial class frmPrincipal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void acGeralImplantacao_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UCImplantacao());
        }

        private void acExportarDados_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UCExportarDados());
        }

        public void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void acImportacaoClientesForn_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UCClientes());
        }
    }
}
