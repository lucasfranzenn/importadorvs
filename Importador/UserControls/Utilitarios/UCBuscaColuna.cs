using DevExpress.XtraEditors;
using Importador.Classes;
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

namespace Importador.UserControls.Utilitarios
{
    public partial class UCBuscaColuna : UCBase
    {
        public UCBuscaColuna()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            gcGrid.DataSource = GerenciadorImportacao.PreencheGrid(txtColuna.Text);
        }

        private void UCBuscaColuna_Load(object sender, EventArgs e)
        {
            if (!ConexaoManager.ConexoesAbertas())
            {
                XtraMessageBox.Show("Conexões não foram estabelecidas!\nConfigure-as corretamente", "..::Importador::..");
                Enabled = false;
            }
        }
    }
}
