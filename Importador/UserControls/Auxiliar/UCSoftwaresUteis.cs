using System;
using System.Data;

namespace Importador.UserControls.Auxiliar
{
    public partial class UCSoftwaresUteis : DevExpress.XtraEditors.XtraUserControl
    {
        public UCSoftwaresUteis()
        {
            InitializeComponent();
        }

        private void gcMain_Load(object sender, EventArgs e)
        {
            DataTable dt = new();

            dt.Columns.Add("Software");
            dt.Columns.Add("Utilização");
            dt.Columns.Add("Gratuito?", typeof(bool));

            dt.Rows.Add(["ESF Database Migration ToolKit", "Utilizado para converter planilhas excel, csv, json e outros formatos para mysql/mariadb", 0]);
            dt.Rows.Add(["DBeaver", "Melhor software para manusear váios modelos de SGBD", 1]);
            dt.Rows.Add(["pgAdmin", "Melhor software para bancos em PostgreeSQL", 1]);
            dt.Rows.Add(["SQL Server Management Studio (SSMS)", "Melhor software para bancos em SQL Server", 1]);
            dt.Rows.Add(["Paradox Data Editor", "Melhor software para manusear tabelas em Paradox", 1]);
            dt.Rows.Add(["LibreOffice", "Software responsável para manusear com planilhas", 1]);
            dt.Rows.Add(["Access PassView", "Software utilizado para quebrar a senha de bancos Access", 1]);
            dt.Rows.Add(["TrIDNet", "Software utilizado para identificar o tipo do arquivo", 1]);

            gcMain.DataSource = dt;
        }
    }
}
