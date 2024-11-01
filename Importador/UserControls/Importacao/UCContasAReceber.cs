﻿using DevExpress.XtraEditors;
using Importador.Classes;
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
using Importador.Classes.JSON;

namespace Importador.UserControls.Importacao
{
    public partial class UCContasAReceber : UCBaseImportacao
    {
        public UCContasAReceber()
        {
            InitializeComponent();
        }

        private void UCContasAReceber_Load(object sender, EventArgs e)
        {
            if (!ConexaoManager.ConexoesAbertas())
            {
                XtraMessageBox.Show("Conexões não foram estabelecidas!\nConfigure-as corretamente", "..::Importador::..");
                Enabled = false;
            }
            else
            {
                txtSqlImportacao.Text = ConsultasJSON.GetSql("contasareceber");
            }
        }
    }
}
