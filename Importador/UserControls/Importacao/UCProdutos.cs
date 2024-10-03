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

namespace Importador.UserControls.Importacao
{
    public partial class UCProdutos : BaseControls.UCBaseImportacao
    {
        public UCProdutos()
        {
            InitializeComponent();
        }

        private void UCProdutos_Load(object sender, EventArgs e)
        {
            if (!ConexaoManager.ConexoesAbertas())
            {
                XtraMessageBox.Show("Conexões não foram estabelecidas!\nConfigure-as corretamente", "..::Importador::..");
                Enabled = false;
            }
            else
            {
                txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(MyC.Tabela);
            }
        }
    }
}
