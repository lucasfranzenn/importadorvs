using Importador.Conexao;
using Importador.UserControls.BaseControls;
using System;
using static Importador.Classes.Constantes;

namespace Importador.UserControls.Conexao
{
    public partial class UCConexaoMyCommerce : UCBaseConexao
    {
        public UCConexaoMyCommerce()
        {
            InitializeComponent();
        }

        private void UCConexaoMyCommerce_Leave(object sender, EventArgs e)
        {
            var conexao = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 0");

            conexao.Host = txtHost.Text;
            conexao.Porta = Convert.ToInt32(txtPorta.Text);
            conexao.Usuario = txtUsuario.Text;
            conexao.Senha = txtSenha.Text;
            conexao.Banco = txtBancoDeDados.Text;

            ConexaoBancoImportador.Update(conexao, Enums.TabelaBancoLocal.conexoes);
        }

        private void UCConexaoMyCommerce_Load(object sender, EventArgs e)
        {
            Classes.Entidades.Conexao entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 0");
            
            if(entidade is null)
            {
                ConexaoBancoImportador.InserirRegistro(new Classes.Entidades.Conexao(Enums.Sistema.MyCommerce), Enums.TabelaBancoLocal.conexoes);
                entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 0");
            }

            txtHost.Text = entidade.Host;
            txtPorta.Text = entidade.Porta.ToString();
            txtUsuario.Text = entidade.Usuario;
            txtSenha.Text = entidade.Senha;
            txtBancoDeDados.Text = entidade.Banco;
        }
    }
}
