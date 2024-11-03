using DevExpress.XtraEditors;
using Importador.Conexao;
using System;
using System.Drawing;
using static Importador.Classes.Constantes;

namespace Importador.UserControls.Componentes
{
    public partial class Observacao : XtraUserControl
    {
        public Observacao(Point Localizacao, Size Tamanho, string Tela)
        {
            InitializeComponent();

            AtualizaProporcoes(Localizacao, Tamanho);

            lblTela.Text = "Observação - " + Tela;
        }

        public void AtualizaProporcoes(Point localizacao, Size tamanho)
        {
            tamanho.Width = tamanho.Width - (int)(tamanho.Width * 0.5575);
            tamanho.Height = tamanho.Height - (int)(tamanho.Height * 0.7391);

            Size = tamanho;

            localizacao.X = localizacao.X - Size.Width;
            Location = localizacao;
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

            entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Observacoes>(Enums.TabelaBancoLocal.observacoes, $"Tela = '{tela}'");

            if (entidade is null)
            {
                ConexaoBancoImportador.InserirRegistro(new Classes.Entidades.Observacoes(tela), Enums.TabelaBancoLocal.observacoes);
                entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Observacoes>(Enums.TabelaBancoLocal.observacoes, $"Tela = '{tela}'");
            }

            txtObservacao.Text = entidade.Observacao;
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
