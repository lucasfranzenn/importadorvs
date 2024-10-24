using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Importador.Conexao;
using Microsoft.Data.Sqlite;
using System;
using System.Data;

namespace Importador.UserControls.Auxiliar
{
    public partial class UCNomenclaturas : XtraUserControl
    {
        public UCNomenclaturas()
        {
            InitializeComponent();
        }

        private void UCNomenclaturas_Load(object sender, EventArgs e)
        {
            SqliteCommand cmd = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            cmd.CommandText = "SELECT NomenclaturaMyCommerce, NomenclaturaImportacao from Nomenclaturas";

            using IDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            gcMain.DataSource = dt;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            SqliteCommand insert = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            DataRowView linha =(DataRowView)e.Row;
            insert.CommandText = $"INSERT INTO NOMENCLATURAS VALUES (NULL, '{linha.Row.ItemArray[0].ToString().ToLower()}', '{linha.Row.ItemArray[1].ToString().ToLower()}')";
            insert.ExecuteNonQuery();
        }
    }
}
