using DevExpress.DataAccess.Sql;
using DevExpress.XtraMap;
using FirebirdSql.Data.FirebirdClient;
using Importador.Classes;
using Importador.Classes.JSON;
using Importador.Conexao;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

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
            // ExecutaParametros(gpParametros.Controls.OfType<Checkbox>)

            IDbCommand sqlQuery = ConexaoManager.instancia.GetConexaoImportacao().CreateCommand();
            sqlQuery.CommandText= txtSqlImportacao.Text;
            IDataReader reader = sqlQuery.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    //
                }
            }

        }
    }
}
