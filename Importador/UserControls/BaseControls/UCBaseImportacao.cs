using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Conexao;

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
    }
}
