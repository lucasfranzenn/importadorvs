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
using Importador.Classes;

namespace Importador.UserControls.Opcoes
{
    public partial class UCIntegracaoJira : UserControls.BaseControls.UCBaseOpcao
    {
        public UCIntegracaoJira()
        {
            InitializeComponent();
        }

        public override void SalvarConfig()
        {
            IniFile.Write("Integracao", "JiraEndPoint", txtEndPointJira.Text);
            IniFile.Write("Integracao", "JiraAuth", txtCredencialJira.Text);
        }

        private void UCIntegracaoJira_Load(object sender, EventArgs e)
        {
            txtEndPointJira.Text = IniFile.Read("Integracao", "JiraEndPoint");
            txtCredencialJira.Text = IniFile.Read("Integracao", "JiraAuth");
        }
    }
}
