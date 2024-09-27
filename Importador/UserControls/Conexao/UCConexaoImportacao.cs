using DevExpress.XtraEditors;
using Importador.Classes.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Importador.Classes.Utils;
using static Importador.Classes.Constantes;
using Importador.UserControls.BaseControls;
using Importador.Conexao;

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
                entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 1");
            }
            catch (Exception)
            {
                ConexaoBancoImportador.InserirRegistro(new Classes.Entidades.Conexao(Enums.Sistema.Importacao), Enums.TabelaBancoLocal.conexoes);
            }
            finally
            {
                entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 1");
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
            var conexao = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 1");

            conexao.TipoBanco = cbTipoBanco.SelectedIndex;
            conexao.Host = txtHost.Text;
            conexao.Porta = Convert.ToInt32(txtPorta.Text);
            conexao.Usuario = txtUsuario.Text;
            conexao.Senha = txtSenha.Text;
            conexao.Banco = txtBancoDeDados.Text;

            ConexaoBancoImportador.Update(conexao, Enums.TabelaBancoLocal.conexoes);    
        }
    }
}
