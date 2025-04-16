using DevExpress.XtraEditors;
using Importador.Conexao;
using Importador.Properties;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importador.UserControls.Componentes
{
    public partial class TempoContado : DirectXForm
    {
        public TempoContado(string tela)
        {
            InitializeComponent();

            Text += tela;
        }

        private void TempoContado_Load(object sender, EventArgs e)
        {
            SqliteCommand cmd = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            string tela = Text.Split('-')[1].TrimStart();
            cmd.CommandText = $"select empresa, strftime('%d/%m/%Y %H:%M', DataHoraInicio) AS Inicio,  strftime('%d/%m/%Y %H:%M', DataHoraFim) AS Término, CASE status WHEN 0 THEN '0 - Contando Tempo' WHEN 1 THEN '1 - Montando SQL' WHEN 2 THEN '2 - Importando Dados' WHEN 3 THEN '3 - Corrigindo SQL' ELSE 'Não identificado' END AS Status, printf('%02d:%02d:%02d',(julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24,((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24 * 60) % 60,((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24 * 60 * 60) % 60)as Minutagem, Observacao from registrosdetempo WHERE CodigoImplantacao = {Configuracoes.Default.CodigoImplantacao} AND tela = '{tela}' UNION ALL SELECT 0 as empresa,'Tempo Total' AS Inicio, NULL AS Término, '5 - Tempo Gasto' AS Status, printf('%02d:%02d:%02d',SUM((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24), (SUM((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24 * 60) % 60), (SUM((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24 * 60 * 60) % 60)) AS Minutagem, NULL AS Observacao from registrosdetempo WHERE CodigoImplantacao = {Configuracoes.Default.CodigoImplantacao} AND tela = '{tela}'";

            using IDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            gcTempo.DataSource = dt;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}