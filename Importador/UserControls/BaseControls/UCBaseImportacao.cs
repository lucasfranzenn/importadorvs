using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Conexao;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace Importador.UserControls.BaseControls
{
    public partial class UCBaseImportacao : UCBase
    {
        public UCBaseImportacao()
        {
            InitializeComponent();
        }

        private void btnResetarSql_Click(object sender, System.EventArgs e)
        {
            txtSqlImportacao.Text = Utils.GetSqlPadrao(MyC.Tabela.ToString());
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
    }
}
