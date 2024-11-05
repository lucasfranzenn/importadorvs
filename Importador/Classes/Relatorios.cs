using FastReport.Data;
using FastReport.Export.PdfSimple;
using FastReport;
using Importador.Conexao;
using Importador.Properties;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Importador.Classes
{
    public static class Relatorios
    {
        internal static void GerarRelatorio()
        {
            FastReport.Utils.RegisteredObjects.AddConnection(typeof(SQLiteDataConnection));
            Report relatorio = new();

            relatorio.Load(Constantes.Caminhos.relatorioGeral);
            relatorio.RegisterData(GetDataTablePeloNome(Constantes.Enums.RelatorioGeralDataTable.Implantacoes), nameof(Constantes.Enums.RelatorioGeralDataTable.Implantacoes));
            relatorio.RegisterData(GetDataTablePeloNome(Constantes.Enums.RelatorioGeralDataTable.Minutagem), nameof(Constantes.Enums.RelatorioGeralDataTable.Minutagem));
            relatorio.Prepare();

            ExportarRelatorioPDF(relatorio, $"Relatorios\\Implantação {Configuracoes.Default.CodigoImplantacao}.pdf");
        }

        internal static void ExportarRelatorioPDF(Report relatorio, string caminho)
        {
            PDFSimpleExport exportPDF = new();
            relatorio.Export(exportPDF, $"Relatorios\\Implantação {Configuracoes.Default.CodigoImplantacao}.pdf");
        }

        internal static DataTable GetDataTablePeloNome(Constantes.Enums.RelatorioGeralDataTable rgdt)
        {
            SqliteCommand cmd = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            cmd.CommandText = Constantes.Mapeamento.ConsultaPorDataTable[rgdt] + $" where codigoimplantacao = {Configuracoes.Default.CodigoImplantacao}";

            using IDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

            return dt;
        }
    }
}
