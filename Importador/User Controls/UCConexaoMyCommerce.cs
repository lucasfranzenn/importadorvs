using DevExpress.Xpo.Logger.Transport;
using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Classes.JSON;
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

namespace Importador.User_Controls
{
    public partial class UCConexaoMyCommerce : DevExpress.XtraEditors.XtraUserControl
    {
        public UCConexaoMyCommerce()
        {
            InitializeComponent();
        }

        private void UCConexaoMyCommerce_Leave(object sender, EventArgs e)
        {
            var conexoesJson = GetConexoesJson();

            conexoesJson.Mycommerce = new Importacao()
            {
                Tipobanco = "mysql",
                Host = txtHost.Text,
                Porta = Convert.ToInt16(txtPorta.Text),
                Usuario = txtUsuario.Text,
                Senha = txtSenha.Text,
                Banco = txtBancoDeDados.Text,
            };

            SetConexoesJson(conexoesJson);
        }

        private void UCConexaoMyCommerce_Load(object sender, EventArgs e)
        {
            var temp = GetImportacao(Enums.Sistema.MyCommerce);

            txtHost.Text = temp.Host;
            txtPorta.Text = temp.Porta.ToString();
            txtUsuario.Text = temp.Usuario;
            txtSenha.Text = temp.Senha;
            txtBancoDeDados.Text = temp.Banco;
        }
    }
}
