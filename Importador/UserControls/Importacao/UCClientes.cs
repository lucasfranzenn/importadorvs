using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
using FirebirdSql.Data.FirebirdClient;
using Importador.Classes;
using Importador.Conexao;
using Importador.Properties;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using static Importador.Classes.Constantes;
using Importador.Classes.Entidades;

namespace Importador.UserControls.Importacao
{
    public partial class UCClientes : BaseControls.UCBaseImportacao
    {
        public UCClientes()
        {
            InitializeComponent();
        }

        private void UCClientes_Load(object sender, EventArgs e)
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

        private async void btnImportar_Click(object sender, EventArgs e)
        {
            new Task(() => lblHorarioInicioImportacao.Text = DateTime.Now.ToString()).Start();

            Utils.AtualizaSQLImportacao(txtSqlImportacao.Text, MyC.Tabela);

            Enabled = false;

            await Task.Run(() => GerenciadorImportacao.Importar(txtSqlImportacao.Text, ref pbImportacao, MyC.Tabela, gcParametros.Controls.OfType<CheckEdit>().ToList()));

            lblHorarioFimImportacao.Text = DateTime.Now.ToString();

            Utils.MostrarNotificacao("Importação dos clientes finalizada", "Importação");

            Enabled = true;
        }

        private void btnResetarSql_Click(object sender, EventArgs e)
        {
            txtSqlImportacao.Text = Utils.GetSqlPadrao(MyC.Tabela.ToString());
        }
    }
}
