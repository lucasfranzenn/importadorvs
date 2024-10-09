using Importador.Conexao;
using Importador.UserControls.BaseControls;
using System;
using static Importador.Classes.Constantes;

namespace Importador.UserControls.Conexao
{
    public partial class UCConexaoImportacao : UCBaseConexao
    {
        public UCConexaoImportacao()
        {
            InitializeComponent();
        }

        private void UCConexaoImportacao_Load(object sender, EventArgs e)
        {
            Classes.Entidades.Conexao entidade;
            try
            {
                entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, $"TipoConexao = 1 and Padrao = 1");
            }
            catch (Exception)
            {
                ConexaoBancoImportador.InserirRegistro(new Classes.Entidades.Conexao(Enums.Sistema.Importacao), Enums.TabelaBancoLocal.conexoes);
            }
            finally
            {
                entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, $"TipoConexao = 1 and Padrao = 1");
                cbTipoBanco.SelectedIndex = entidade.TipoBanco;
                txtHost.Text = entidade.Host;
                txtPorta.Text = entidade.Porta.ToString();
                txtUsuario.Text = entidade.Usuario;
                txtSenha.Text = entidade.Senha;
                txtBancoDeDados.Text = entidade.Banco;
            }
        }

        private void UCConexaoImportacao_Leave(object sender, EventArgs e)
        {
            var conexao = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, $"TipoConexao = 1 and TipoBanco = {cbTipoBanco.SelectedIndex}");

            conexao.TipoBanco = cbTipoBanco.SelectedIndex;
            conexao.Host = txtHost.Text;
            conexao.Porta = Convert.ToInt32(txtPorta.Text);
            conexao.Usuario = txtUsuario.Text;
            conexao.Senha = txtSenha.Text;
            conexao.Banco = txtBancoDeDados.Text;
            conexao.Padrao = true;

            ConexaoBancoImportador.Update(conexao, Enums.TabelaBancoLocal.conexoes);
            ConexaoBancoImportador.AtualizarConexaoPadrao(conexao);
        }

        private void AtualizaInformacoesConexao()
        {
            Classes.Entidades.Conexao conexao;

            try
            {
                conexao = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, $"TipoConexao = 1 and TipoBanco = {cbTipoBanco.SelectedIndex}");
            }
            catch (Exception)
            {
                ConexaoBancoImportador.InserirRegistro(new Classes.Entidades.Conexao((Enums.TipoBanco)cbTipoBanco.SelectedIndex), Enums.TabelaBancoLocal.conexoes);
            }

            conexao = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, $"TipoConexao = 1 and TipoBanco = {cbTipoBanco.SelectedIndex}");

            cbTipoBanco.SelectedIndex = conexao.TipoBanco;
            txtHost.Text = conexao.Host;
            txtPorta.Text = conexao.Porta.ToString();
            txtUsuario.Text = conexao.Usuario;
            txtSenha.Text = conexao.Senha;
            txtBancoDeDados.Text = conexao.Banco;
        }

        private void cbTipoBanco_SelectedValueChanged(object sender, EventArgs e)
        {
            AtualizaInformacoesConexao();
        }
    }
}
