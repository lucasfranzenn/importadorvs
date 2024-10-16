using DevExpress.XtraEditors;
using Importador.Conexao;
using System;
using System.Drawing;
using static Importador.Classes.Constantes;

namespace Importador.UserControls.Componentes
{
    public partial class Observacao : XtraUserControl
    {
        public Observacao()
        {
            InitializeComponent();
        }

        public Observacao(Point Localizacao, Size Tamanho, string Tela)
        {
            InitializeComponent();

            Tamanho.Width = Tamanho.Width - (int)(Tamanho.Width * 0.5575);
            Tamanho.Height = Tamanho.Height - (int)(Tamanho.Height * 0.7391);

            Size = Tamanho;

            Localizacao.X = Localizacao.X - Size.Width;
            Location = Localizacao;

            lblTela.Text = "Observação - " + Tela;
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Dispose();
        }

        private void Observacao_Load(object sender, EventArgs e)
        {
            Classes.Entidades.Observacoes entidade;
            string tela = lblTela.Text.Split('-')[1].TrimStart();
            try
            {
                entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Observacoes>(Enums.TabelaBancoLocal.observacoes, $"Tela = '{tela}'");
            }
            catch (Exception)
            {
                ConexaoBancoImportador.InserirRegistro(new Classes.Entidades.Observacoes(tela), Enums.TabelaBancoLocal.observacoes);
            }
            finally
            {
                entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Observacoes>(Enums.TabelaBancoLocal.observacoes, $"Tela = '{tela}'");
                txtObservacao.Text = entidade.Observacao;
            }
        }

        private void Observacao_Leave(object sender, EventArgs e)
        {
            string tela = lblTela.Text.Split('-')[1].TrimStart();
            var observacao = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Observacoes>(Enums.TabelaBancoLocal.observacoes, $"Tela = '{tela}'");

            observacao.Observacao = txtObservacao.Text;

            ConexaoBancoImportador.Update(observacao, Enums.TabelaBancoLocal.observacoes);
        }
    }
}
