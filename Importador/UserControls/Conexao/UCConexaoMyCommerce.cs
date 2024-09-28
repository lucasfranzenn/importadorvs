using DevExpress.Xpo.Logger.Transport;
using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Conexao;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Importador.Classes.Utils;
using static Importador.Classes.Constantes;
using Importador.UserControls.BaseControls;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.X509.Qualified;

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
            Classes.Entidades.Conexao entidade;
            try
            {
                entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 0");
            }
            catch (Exception)
            {
                ConexaoBancoImportador.InserirRegistro(new Classes.Entidades.Conexao(Enums.Sistema.MyCommerce), Enums.TabelaBancoLocal.conexoes);
            }
            finally
            {
                entidade = ConexaoBancoImportador.GetEntidade<Classes.Entidades.Conexao>(Enums.TabelaBancoLocal.conexoes, "TipoConexao = 0");
                txtHost.Text = entidade.Host;
                txtPorta.Text = entidade.Porta.ToString();
                txtUsuario.Text = entidade.Usuario;
                txtSenha.Text = entidade.Senha;
                txtBancoDeDados.Text = entidade.Banco;
            }
        }
    }
}
