using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.Properties;
using Importador.UserControls.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Importador.Classes.Constantes;

namespace Importador.UserControls.BaseControls
{
    public partial class UCBaseImportacao : UCBase
    {
        public UCBaseImportacao()
        {
            InitializeComponent();
        }

        private void btnResetarSql_Click(object sender, EventArgs e)
        {
            txtSqlImportacao.Text = Utils.GetSqlPadrao(MyC.Tabela.ToString());
        }

        protected async void btnImportar_Click(object sender, EventArgs e)
        {
            if (GerenciadorImportacao.VerificarSQL(txtSqlImportacao.Text) is string erro)
            {
                XtraMessageBox.Show(erro, "..::Importador::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblHorarioInicioImportacao.Text = DateTime.Now.ToString();

            List<CheckEdit> listaParametros = gcParametros.Controls.OfType<CheckEdit>().ToList();

            Utils.AtualizaSQLImportacao(txtSqlImportacao.Text, MyC.Tabela.ToString());

            ConexaoBancoImportador.AtualizaParametros(MyC, listaParametros);

            Enabled = false;

            await Task.Run(() => GerenciadorImportacao.Importar(txtSqlImportacao.Text, pbImportacao, MyC.Tabela.ToString(), listaParametros.Where(p => p.Checked).ToList()));

            lblHorarioFimImportacao.Text = DateTime.Now.ToString();

            ConexaoBancoImportador.AtualizarTempoImportacao(lblHorarioInicioImportacao.Text, lblHorarioFimImportacao.Text, MyC.Tabela.ToString());

            Utils.MostrarNotificacao($"Importação dos {MyC.Tabela.ToString()} finalizada", "Importação");

            Enabled = true;
        }

        protected void UCBaseImportacao_Load(object sender, EventArgs e)
        {
            //Validação necessária para não bugar o designer do Visual Studio
            if (DesignMode) return;

            if (!ConexaoManager.ConexoesAbertas())
            {
                Enabled = false;
                return;
            }

            Parametro param;

            txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(MyC.Tabela.ToString());

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

            if (ConexaoBancoImportador.ExisteObservacao(MyC.Tabela.ToString())) { btnObservacao.ImageOptions.Image = Resources.newtask_16x16; }

            if (ConexaoBancoImportador.EstaContandoTempo(MyC.Tabela.ToString())) { AlterarContagemTempo(true); }
        }

        protected void AlternarVisibilidade()
        {
            Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = !c.Enabled);
        }

        protected void btnObservacao_Click(object sender, EventArgs e)
        {
            var obsObservacao = new Observacao(btnObservacao.Location, Size, MyC.Tabela.ToString());

            AlternarVisibilidade();
            Controls.Add(obsObservacao);

            obsObservacao.BringToFront();

            obsObservacao.Disposed += (sender, args) => AlternarVisibilidade();
            SizeChanged -= (sender, args) => obsObservacao.AtualizaProporcoes(btnObservacao.Location, Size);
            SizeChanged += (sender, args) => obsObservacao.AtualizaProporcoes(btnObservacao.Location, Size);
        }

        private void btnVerificarSintaxeSQL_Click(object sender, EventArgs e)
        {
            if (GerenciadorImportacao.VerificarSQL(txtSqlImportacao.Text) is string erro)
            {
                XtraMessageBox.Show(erro, "..::Importador::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("Comando SQL executado sem erros!", "..::Importador::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ContarTempo()
        {
            if (Convert.ToBoolean(btnContarTempo.Tag) == false)
            {
                if (ConexaoBancoImportador.EstaContandoTempo() is string tela)
                {
                    XtraMessageBox.Show($"Usuário já esta contando tempo.\nImplantação {tela}", "..::Importador::..");
                    return;
                }
                AlterarContagemTempo(true);

                ConexaoBancoImportador.InserirRegistro(new RegistroDeTempo(MyC.Tabela.ToString()), Enums.TabelaBancoLocal.registrosdetempo);
                return;
            }

            RegistroDeTempo tempo = ConexaoBancoImportador.GetEntidade<RegistroDeTempo>(Enums.TabelaBancoLocal.registrosdetempo, $"tela = '{MyC.Tabela.ToString()}' and Operador = '{Configuracoes.Default.UsuarioLogado}' and Status = 0");

            tempo.DataHoraFim = Convert.ToDateTime(DateTime.Now.ToString());

            using (var dialog = new FinalizarContagemDialog())
            {
                if (dialog.ShowDialog() != DialogResult.OK) { return; }

                tempo.Status = Convert.ToInt32(dialog.cbStatus.Text[0].ToString());
                tempo.Observacao = string.IsNullOrEmpty(dialog.txtObservacao.Text) ? null : dialog.txtObservacao.Text;

                ConexaoBancoImportador.Update(tempo, Enums.TabelaBancoLocal.registrosdetempo);
                AlterarContagemTempo(false);

            }

        }

        protected void AlterarContagemTempo(bool estaContando)
        {
            if (estaContando)
            {
                btnContarTempo.ImageOptions.Image = Resources.iconsetredtoblack4_16x16;
                btnContarTempo.Text = "Finalizar Contagem";
                btnContarTempo.Tag = true;
                return;
            }

            btnContarTempo.ImageOptions.Image = Resources.iconsetsigns3_16x16;
            btnContarTempo.Text = "Iniciar Contagem";
            btnContarTempo.Tag = false;
        }

        private void btnContarTempo_Click(object sender, EventArgs e)
        {
            ContarTempo();
        }

        private void btnVerTempoContado_Click(object sender, EventArgs e)
        {
            new TempoContado(MyC.Tabela.ToString()).ShowDialog();
        }
    }
}
