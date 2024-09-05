using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;
using UC = Importador.UserControls;
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
            AlteraAba(ref fcPrincipal, new UC.Geral.UCImplantacao());
        }

        private void acExportarDados_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Geral.UCExportarDados());
        }

        public void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void acImportacaoClientesForn_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Importacao.UCClientes());
        }

        private void acConexaoMyCommerce_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Conexao.UCConexaoMyCommerce());
        }

        private void acConexaoImportacao_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Conexao.UCConexaoImportacao());
        }

        private void acImportacaoProdutos_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Importacao.UCProdutos());
        }

        private void frmPrincipal_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            SalvarSkin(defaultLookAndFeel1.LookAndFeel.SkinName, defaultLookAndFeel1.LookAndFeel.ActiveSvgPaletteName);
        }

        private void acUtilitariosBuscarColuna_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Utilitarios.UCBuscaColuna());
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaSkin(ref defaultLookAndFeel1);
        }

        private void acImportacaoProdutosST_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Importacao.UCProdutosST());
        }

        private void acImportacaoContasAPagar_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Importacao.UCContasAPagar());
        }

        private void acImportacaoContasAReceber_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Importacao.UCContasAReceber());
        }

        private void acImportacaoPreVendas_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Importacao.UCPreVendas());
        }

        private void acImportacaoServicos_Click(object sender, EventArgs e)
        {
            AlteraAba(ref fcPrincipal, new UC.Importacao.UCServicos());
        }
    }
}
