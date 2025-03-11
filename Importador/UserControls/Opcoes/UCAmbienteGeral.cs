using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Importador.UserControls.BaseControls;
using DevExpress.XtraMap.Drawing;

namespace Importador.UserControls.Opcoes
{
    public partial class UCAmbienteGeral : UCBaseOpcao
    {
        public UCAmbienteGeral()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            txtDiretorioPastaPython.Text = Classes.Utils.SelecionarPasta(txtDiretorioPastaPython.Text);
        }

        private void UCAmbienteGeral_Load(object sender, EventArgs e)
        {
            txtDiretorioPastaPython.Text = Classes.IniFile.Read("AmbienteGeral", "PythonFolderPath");
            txtCaminhoSQLPadrao.Text = Classes.IniFile.Read("AmbienteGeral", "DefaultSQLPath");
        }

        public override void SalvarConfig()
        {
            Classes.IniFile.Write("AmbienteGeral", "PythonFolderPath", txtDiretorioPastaPython.Text);
            Classes.IniFile.Write("AmbienteGeral", "DefaultSQLPath", txtCaminhoSQLPadrao.Text);
        }

        private void btnProcurarSQLPadrao_Click(object sender, EventArgs e)
        {
            txtCaminhoSQLPadrao.Text = Classes.Utils.SelecionarArquivo(txtCaminhoSQLPadrao.Text, "Json|*.json");
        }
    }
}
