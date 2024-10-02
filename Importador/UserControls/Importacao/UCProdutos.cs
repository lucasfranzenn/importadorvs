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

        private async void btnImportar_Click(object sender, EventArgs e)
        {
            new Task(() => lblHorarioInicioImportacao.Text = DateTime.Now.ToString()).Start();

            Utils.AtualizaSQLImportacao(txtSqlImportacao.Text, MyC.Tabela);

            Enabled = false;

            await Task.Run(() => GerenciadorImportacao.Importar(txtSqlImportacao.Text, ref pbImportacao, MyC.Tabela, gcParametros.Controls.OfType<CheckEdit>().Where(p => p.Checked).ToList()));

            lblHorarioFimImportacao.Text = DateTime.Now.ToString();

            Utils.MostrarNotificacao($"Importação dos {MyC.Tabela.ToString()} finalizada", "Importação");

            Enabled = true;
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
