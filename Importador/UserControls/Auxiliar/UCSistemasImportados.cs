using DevExpress.XtraEditors;
using Importador.Conexao;
using Microsoft.Data.Sqlite;
using System;
using System.Data;

namespace Importador.UserControls.Auxiliar
{
    public partial class UCSistemasImportados : DevExpress.XtraEditors.XtraUserControl
    {
        public UCSistemasImportados()
        {
            InitializeComponent();
        }

        private void UCSistemasImportados_Load(object sender, EventArgs e)
        {
            SqliteCommand cmd = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            cmd.CommandText = "SELECT CodigoImplantacao as 'Codigo da Implantação', RazaoSocialCliente AS 'Razao Social', SistemaAntigo AS 'Sistema Importado', BancoDeDados FROM Implantacoes";

            using IDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            gcMain.DataSource = dt;
        }
    }
}
