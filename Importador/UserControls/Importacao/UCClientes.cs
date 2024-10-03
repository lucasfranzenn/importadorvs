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
    }
}
