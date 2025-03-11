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
using static Importador.Classes.Constantes;

namespace Importador.UserControls.Opcoes
{
    public partial class UCIntegracaoGoogleDrive : UserControls.BaseControls.UCBaseOpcao
    {
        public UCIntegracaoGoogleDrive()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.InitialDirectory = txtCaminhoCredencial.Text;
            ofd.Filter = "JSON | *.json";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoCredencial.Text = ofd.FileName;
            }
        }

        private void UCIntegracaoGoogleDrive_Load(object sender, EventArgs e)
        {
            txtCaminhoCredencial.Text = IniFile.Read("Integracao", "GoogleDriveCredentialPath");
            txtParentFolderID.Text = IniFile.Read("Integracao", "GoogleDriveParentFolderId");
        }

        public override void SalvarConfig()
        {
            IniFile.Write("Integracao", "GoogleDriveCredentialPath", txtCaminhoCredencial.Text);
            IniFile.Write("Integracao", "GoogleDriveParentFolderId", txtParentFolderID.Text);
        }
    }
}
