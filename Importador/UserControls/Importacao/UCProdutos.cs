using System;
using System.Linq;
using System.Windows.Forms;

namespace Importador.UserControls.Importacao
{
    public partial class UCProdutos : BaseControls.UCBaseImportacao
    {
        public UCProdutos()
        {
            InitializeComponent();
        }

        private void btnImportarAdicionais_Click(object sender, EventArgs e)
        {
            var adicionais = new UCProdutosAdicionais();
            TrocaForm();
            adicionais.Dock = DockStyle.Fill;
            Controls.Add(adicionais);

            adicionais.Disposed += (sender, args) => TrocaForm();
        }

        private void TrocaForm()
        {
            Controls.OfType<Control>().ToList().ForEach(c => c.Visible = !c.Visible);
        }
    }
}
