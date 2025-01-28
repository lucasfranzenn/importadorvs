using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Commands;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importador.UserControls.Importacao
{
    public partial class UCCentralizador : UCBase
    {
        public UCCentralizador()
        {
            InitializeComponent();
        }

        private void UCCentralizador_Load(object sender, EventArgs e)
        {
            if (!ConexaoManager.ConexoesAbertas())
            {
                Enabled = false;
                return;
            }
        }

        private async void btnCentralizarClientes_Click(object sender, EventArgs e)
        {
            txtTaxaMinima.Text = string.IsNullOrEmpty(txtTaxaMinima.Text) ? "60" : txtTaxaMinima.Text;

            if (XtraMessageBox.Show("Tem certeza que deseja efetuar essa ação?", "..::Importador de Dados::..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Centralizador centralizador = new Centralizador(Convert.ToInt32(txtTaxaMinima.Text));
                Enabled = false;
                AlteraTextoProgressBar("Clientes", 1);
                await Task.Run(() => centralizador.AjustarClientes(pbImportacao));

                Utils.MostrarNotificacao("Finalizado Centralização de Clientes", "Centralização de dados");
                AlteraTextoProgressBar("Clientes", 2);
                Enabled = true;
            }
        }

        private async void btnCentralizarProdutos_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Tem certeza que deseja efetuar essa ação?", "..::Importador de Dados::..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Centralizador centralizador = new Centralizador(100);
                Enabled = false;
                AlteraTextoProgressBar("Produtos", 1);
                await Task.Run(() => centralizador.AjustarProdutos(pbImportacao));


                Utils.MostrarNotificacao("Finalizado Centralização de Produtos", "Centralização");
                AlteraTextoProgressBar("Produtos", 2);
                Enabled = true;
            }
        }

        private async void btnCentralizarSecoes_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Tem certeza que deseja efetuar essa ação?", "..::Importador de Dados::..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Centralizador centralizador = new Centralizador(100);
                Enabled = false;
                AlteraTextoProgressBar("Secoes/Fabricantes", 1);
                await Task.Run(() => centralizador.AjustarSecoes(pbImportacao));

                Utils.MostrarNotificacao("Finalizado Centralização de Seções/Grupos/SubGrupos e Fornecedores", "Centralização");
                AlteraTextoProgressBar("Secoes/Fabricantes", 2);
                Enabled = true;
            }
        }

        private void AlteraTextoProgressBar(string dados, int tipo)
        {
            switch (tipo)
            {
                case 1:
                    pbImportacao.CustomDisplayText += (sender, args) =>
                    {
                        args.DisplayText = $"Centralizando Dados de {dados}, porfavor aguarde...";
                    };
                    break;
                case 2:
                    pbImportacao.CustomDisplayText += (sender, args) =>
                    {
                        args.DisplayText = $"Dados de {dados} foram centralizados!";
                    };
                    break;
            }
           

            pbImportacao.Update();
        }
    }
}
