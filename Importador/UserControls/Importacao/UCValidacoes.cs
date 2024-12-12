using Importador.UserControls.BaseControls;
using System;
using Importador.Classes;
using Importador.Conexao;
using Importador.Properties;

namespace Importador.UserControls.Importacao
{
    public partial class UCValidacoes : UCBase
    {
        const int qtdeValidacoes = 5;
        const int qtdeAjustes = 1;

        public UCValidacoes()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            txtLog.Clear();

            pbProgresso.EditValue = 0;
            pbProgresso.Properties.Maximum = qtdeValidacoes;

            IniciarValidacoes();

            Utils.CriarTXT(txtLog.Text, $"Validacoes\\log_validacoes");

            Utils.MostrarNotificacao("Validações dos dados finalizadas", $"Implantação {Configuracoes.Default.CodigoImplantacao}");
        }

        private void IniciarValidacoes()
        {
            txtLog.AppendText(Validacoes.VerificarCestInvalidos());
            AtualizaProgressBar();

            txtLog.AppendText(Validacoes.VerificarNcmInvalidos());
            AtualizaProgressBar();

            txtLog.AppendText(Validacoes.VerificarCidadesCodIBGE());
            AtualizaProgressBar();

            txtLog.AppendText(Validacoes.VerificarCPFCNPJDuplicado());
            AtualizaProgressBar();

            txtLog.AppendText(Validacoes.VerificarContasQuitadasPendentes());
            AtualizaProgressBar();

            txtLog.AppendText(Validacoes.VerificarFiscal());
            AtualizaProgressBar();
        }

        private void AtualizaProgressBar()
        {
            pbProgresso.PerformStep();
            pbProgresso.Update();
        }

        private void UCValidacoes_Load(object sender, EventArgs e)
        {
            if (!ConexaoManager.ConexoesAbertas())
            {
                Enabled = false;
                return;
            }
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            txtLog.Clear();

            pbProgresso.EditValue = 0;
            pbProgresso.Properties.Maximum = qtdeAjustes;

            IniciarAjustes();

            Utils.MostrarNotificacao("Ajustes dos dados finalizadas", $"Implantação {Configuracoes.Default.CodigoImplantacao}");
        }

        private void IniciarAjustes()
        {
            txtLog.AppendText(Validacoes.AjustarCodIBGE());
            AtualizaProgressBar();
        }
    }
}
