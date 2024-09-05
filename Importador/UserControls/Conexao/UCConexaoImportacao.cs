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
            var temp = GetImportacao(Enums.Sistema.Importacao);

            txtHost.Text = temp.Host;
            txtPorta.Text = temp.Porta.ToString();
            txtUsuario.Text = temp.Usuario;
            txtSenha.Text = temp.Senha;
            txtBancoDeDados.Text = temp.Banco;
            cbTipoBanco.SelectedText = Mapeamento.NomePorTipoBanco[temp.Tipobanco];
        }

        private void UCConexaoImportacao_Leave(object sender, EventArgs e)
        {
            var conexoesJson = GetConexoesJson();

            conexoesJson.Importacao = new Classes.JSON.Importacao()
            {
                Tipobanco = Mapeamento.TipoBancoPorNome[cbTipoBanco.SelectedText],
                Host = txtHost.Text,
                Porta = Convert.ToInt16(txtPorta.Text),
                Usuario = txtUsuario.Text,
                Senha = txtSenha.Text,
                Banco = txtBancoDeDados.Text,
            };

            SetConexoesJson(conexoesJson);
        }
    }
}
