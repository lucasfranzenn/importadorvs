using Importador.UserControls.BaseControls;
using System;
using System.Windows.Forms;

namespace Importador.UserControls.Importacao
{
    public partial class UCProdutosAdicionais : UCBase
    {
        public UCProdutosAdicionais()
        {
            InitializeComponent();

            tcAdicionais.TabPages[0].Controls.Add(new UCEstoque() { Dock = DockStyle.Fill });
            tcAdicionais.TabPages[1].Controls.Add(new UCSecoes() { Dock = DockStyle.Fill });
            tcAdicionais.TabPages[2].Controls.Add(new UCGrupos() { Dock = DockStyle.Fill });
            tcAdicionais.TabPages[3].Controls.Add(new UCSubGrupos() { Dock = DockStyle.Fill });
            tcAdicionais.TabPages[4].Controls.Add(new UCFabricantes() { Dock = DockStyle.Fill });
            tcAdicionais.TabPages[5].Controls.Add(new UCFornecedores() { Dock = DockStyle.Fill });
            tcAdicionais.TabPages[6].Controls.Add(new UCCodigoBarra() { Dock = DockStyle.Fill });
            tcAdicionais.TabPages[7].Controls.Add(new UCProdutosKits() { Dock = DockStyle.Fill });
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Dispose();
        }
    }
}
