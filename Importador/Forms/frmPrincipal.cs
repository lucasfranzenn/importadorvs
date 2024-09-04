using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;
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

        private void acConexaoMyCommerce_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UCConexaoMyCommerce());
        }

        private void acConexaoImportacao_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UCConexaoImportacao());
        }

        private void acImportacaoProdutos_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UCProdutos());
        }

        private void frmPrincipal_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            SalvarSkin(defaultLookAndFeel1.LookAndFeel.SkinName, defaultLookAndFeel1.LookAndFeel.ActiveSvgPaletteName);
        }

        private void acUtilitariosBuscarColuna_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UCBuscaColuna());
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaSkin(ref defaultLookAndFeel1);
        }
    }
}
