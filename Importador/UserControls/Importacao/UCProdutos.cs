using DevExpress.XtraEditors;
using Importador.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Importador.Conexao;
using DevExpress.XtraBars.FluentDesignSystem;
using System.Threading;

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
