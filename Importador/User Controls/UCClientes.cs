using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
using FirebirdSql.Data.FirebirdClient;
using Importador.Classes;
using Importador.Classes.JSON;
using Importador.Conexao;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using static Importador.Classes.VariaveisGlobais;

namespace Importador.User_Controls
{
    public partial class UCClientes : UCImportacaoBase
    {
        public UCClientes()
        {
            InitializeComponent();
        }

        private void UCClientes_Load(object sender, EventArgs e)
        {
            if (ConexaoManager.ConexoesAbertas())
            {
                txtSqlImportacao.Text = ConsultasJSON.GetSql("clientes");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Conexões não foram estabelecidas!\nConfigure-as corretamente", "..::Importador::..");
                Enabled = false;
            }


        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            lblHorarioInicioImportacao.Text = DateTime.Now.ToString();

            GerenciadorImportacao.Importar(txtSqlImportacao.Text, ref pbImportacao, Tabelas.clientes, gcParametros.Controls.OfType<CheckEdit>().ToList());

            lblHorarioFimImportacao.Text = DateTime.Now.ToString();

            Utils.MostrarNotificacao("Importação dos clientes finalizada", "Importação");

        }
    }
}
