using DevExpress.XtraEditors;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.UserControls.BaseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Importador.Classes.Constantes;

namespace Importador.UserControls.Importacao
{
    public partial class UCGenerico : UCBaseImportacao
    {
        public UCGenerico()
        {
            InitializeComponent();
        }

        private void cbTabelas_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                cbTabelas.Properties.Items.Add(cbTabelas.Text);
            }
        }

        private void AlterarSql()
        {
            txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(cbTabelas.SelectedText);
        }
    }
}
