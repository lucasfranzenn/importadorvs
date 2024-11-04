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

            Report rpt = new();

            SqliteCommand cmd = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            cmd.CommandText = $"SELECT codigoimplantacao, RazaoSocialCliente, SistemaAntigo, BancoDeDados, RegimeEmpresa, NomeResponsavel,Workflow FROM Implantacoes i where codigoimplantacao  = {Configuracoes.Default.CodigoImplantacao}";

            using IDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            cmd.CommandText = $"select tela, strftime('%d/%m/%Y %H:%M', DataHoraInicio) AS Inicio,  strftime('%d/%m/%Y %H:%M', DataHoraFim) AS Término, CASE status WHEN 0 THEN '0 - Contando Tempo' WHEN 1 THEN '1 - Montando SQL' WHEN 2 THEN '2 - Importando Dados' ELSE 'Não identificado' END AS Status, printf('%02d:%02d:%02d',(julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24,((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24 * 60) % 60,round(((julianday(datahorafim) - julianday(datahorainicio)) * 24 * 60 * 60)) % 60 ) as Minutagem, Observacao from registrosdetempo where codigoimplantacao = {Configuracoes.Default.CodigoImplantacao} UNION ALL SELECT tela, 'Tempo Total' AS Inicio, NULL AS Término, CASE status WHEN 0 THEN '0 - Contando Tempo' WHEN 1 THEN '1 - Montando SQL' WHEN 2 THEN '2 - Importando Dados' ELSE 'Não identificado' END AS Status, printf('%02d:%02d:%02d',        (SUM((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24) +          (SUM((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24 * 60) / 60)) % 24,        (SUM((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24 * 60) % 60),        (SUM(round(((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24 * 60 * 60)) % 60)) % 60     ), NULL AS Observacao from registrosdetempo WHERE CodigoImplantacao = {Configuracoes.Default.CodigoImplantacao} GROUP BY tela, Status";
            using IDataReader reader2 = cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(reader2);

            rpt.Load(Constantes.Caminhos.relatorioGeral);
            rpt.RegisterData(dt, "Implantacoes");
            rpt.RegisterData(dt2, "Minutagem");
            rpt.Prepare();

            PDFSimpleExport exportPDF = new();
            rpt.Export(exportPDF, $"Relatorios\\Implantação {Configuracoes.Default.CodigoImplantacao}.pdf");
        }
    }
}
