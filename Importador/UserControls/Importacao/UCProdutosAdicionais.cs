using DevExpress.Utils.Extensions;
using DevExpress.Xpo.Metadata.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using Importador.Classes;
using Importador.Classes.Entidades;
using Importador.Conexao;
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
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Dispose();
        }
    }
}
