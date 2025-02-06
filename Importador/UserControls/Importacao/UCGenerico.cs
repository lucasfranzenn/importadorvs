using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.Properties;
using Importador.UserControls.BaseControls;
using Importador.UserControls.Componentes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Importador.Classes.Constantes;

namespace Importador.UserControls.Importacao
{
    public partial class UCGenerico : UCBaseImportacao
    {
        public UCGenerico()
        {
            InitializeComponent();

            btnImportar.Click -= btnImportar_Click;
            Load -= UCBaseImportacao_Load;
            btnObservacao.Click -= btnObservacao_Click;
        }

        private void cbTabelas_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus && !string.IsNullOrWhiteSpace(cbTabelas.Text) && !cbTabelas.Properties.Items.Contains(cbTabelas.Text))
            {
                cbTabelas.Properties.Items.Add(cbTabelas.Text);
                txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(cbTabelas.Text);
            }
        }

        private void AlterarSql()
        {
            txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(cbTabelas.SelectedText);
        }

        private void cbTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbTabelas.Properties.Items.Contains(cbTabelas.Text) || cbTabelas.SelectedIndex == 0) { return; }

            txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(cbTabelas.Text);
            if (ConexaoBancoImportador.ExisteObservacao(cbTabelas.Text)) { btnObservacao.ImageOptions.Image = Resources.newtask_16x16; }
            else { btnObservacao.ImageOptions.Image = Resources.edittask_16x16; }
        }

        private async void btnImportar_Click_1(object sender, EventArgs e)
        {
            if (cbTabelas.SelectedIndex == 0) { XtraMessageBox.Show("Essa tabela não é válida.", "..::Importador::.."); return; }

            if (GerenciadorImportacao.VerificarSQL(txtSqlImportacao.Text) is string erro)
            {
                XtraMessageBox.Show(erro, "..::Importador::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblHorarioInicioImportacao.Text = DateTime.Now.ToString();

            List<CheckEdit> listaParametros = gcParametros.Controls.OfType<CheckEdit>().ToList();

            Utils.AtualizaSQLImportacao(txtSqlImportacao.Text, cbTabelas.Text);

            ConexaoBancoImportador.AtualizaParametros(MyC, listaParametros);

            Enabled = false;

            await Task.Run(() => GerenciadorImportacao.Importar(txtSqlImportacao.Text, pbImportacao, cbTabelas.Text, listaParametros.Where(p => p.Checked).ToList()));

            lblHorarioFimImportacao.Text = DateTime.Now.ToString();

            ConexaoBancoImportador.AtualizarTempoImportacao(lblHorarioInicioImportacao.Text, lblHorarioFimImportacao.Text, cbTabelas.Text, GerenciadorImportacao.GetQtdRegistros(txtSqlImportacao.Text));

            Utils.MostrarNotificacao($"Importação dos {cbTabelas.SelectedText} finalizada", "Importação");

            Enabled = true;
        }

        private void UCGenerico_Load(object sender, EventArgs e)
        {
            //Validação necessária para não bugar o designer do Visual Studio
            if (DesignMode) return;

            if (!ConexaoManager.ConexoesAbertas())
            {
                Enabled = false;
                return;
            }

            var cmd = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            cmd.CommandText = $"select tabelaconsulta from consultas where codigoimplantacao = {Configuracoes.Default.CodigoImplantacao} and tabelaconsulta not in ('{string.Join("', '", (Enums.TabelaMyCommerce[])Enum.GetValues(typeof(Enums.TabelaMyCommerce)))}')";

            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                    cbTabelas.Properties.Items.Add(reader["tabelaconsulta"]);

            Parametro param;

            if (cbTabelas.Properties.Items.Count > 1)
            {
                cbTabelas.SelectedIndex = 1;
                txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(cbTabelas.Text);
            }

            foreach (var parametro in gcParametros.Controls.OfType<CheckEdit>().ToList())
            {
                param = ConexaoBancoImportador.GetEntidade<Parametro>(Enums.TabelaBancoLocal.parametros, $"Tela = '{MyC.Tabela}' and NomeParametro = '{parametro.Name}'");

                if (param is null)
                {
                    ConexaoBancoImportador.InserirRegistro(new Parametro(MyC, parametro), Enums.TabelaBancoLocal.parametros);
                    param = ConexaoBancoImportador.GetEntidade<Parametro>(Enums.TabelaBancoLocal.parametros, $"Tela = '{MyC.Tabela}' and NomeParametro = '{parametro.Name}'");
                }

                parametro.Checked = param.Valor;
            }

            if (ConexaoBancoImportador.ExisteObservacao(cbTabelas.Text)) { btnObservacao.ImageOptions.Image = Resources.newtask_16x16; }

            if (ConexaoBancoImportador.EstaContandoTempo(MyC.Tabela.ToString())) { AlterarContagemTempo(true); }
        }

        private void btnObservacao_Click_1(object sender, EventArgs e)
        {
            var obsObservacao = new Observacao(btnObservacao.Location, Size, cbTabelas.Text);

            AlternarVisibilidade();
            Controls.Add(obsObservacao);

            obsObservacao.BringToFront();

            obsObservacao.Disposed += (sender, args) => AlternarVisibilidade();
            SizeChanged -= (sender, args) => obsObservacao.AtualizaProporcoes(btnObservacao.Location, Size);
            SizeChanged += (sender, args) => obsObservacao.AtualizaProporcoes(btnObservacao.Location, Size);
        }
    }
}
