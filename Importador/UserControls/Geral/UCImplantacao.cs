using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Classes.JSON;
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
using static Importador.Classes.Utils;

namespace Importador.UserControls.Geral
{
    public partial class UCImplantacao : UCBase
    {
        public UCImplantacao()
        {
            InitializeComponent();
        }

        private void UCImplantacao_Load(object sender, EventArgs e)
        {
            CarregaInformacoes(GetImplantacaoJson());
        }

        private void CarregaInformacoes(ImplantacaoJson implantacao)
        {
            #region Setar Informações do Cliente/Responsável
            txtCliente.Text = implantacao.RazaoCliente;
            txtResponsavel.Text = $"{implantacao.Responsavel.Nome}";
            txtSistemaERP.Text = implantacao.SistemaAntigo;
            txtFormularioOriginal.Text = implantacao.LinkFormulario.ToString();
            txtBackupOriginal.Text = implantacao.LinkBackup.ToString();
            #endregion

            #region Setar Informações de importação
            rgRegime.SelectedIndex = implantacao.RegimeEmpresa;
            cbImportarClientes.SelectedIndex = implantacao.OpcoesImportar.Clientes;
            cbImportarFornecedores.SelectedIndex = implantacao.OpcoesImportar.Fornecedores;
            cbImportarContasAPagar.SelectedIndex = implantacao.OpcoesImportar.ContasAPagar;
            cbImportarContasAReceber.SelectedIndex = implantacao.OpcoesImportar.ContasAReceber;
            chkImportarEstoque.Checked = implantacao.OpcoesImportar.Estoque;
            #endregion

            #region Setar Importação dos Produtos
            if (implantacao.OpcoesImportar.Produtos.Importar)
            {
                cbImportarProdutosOpcoes.Properties.Items[0].CheckState = CheckState.Checked;
                cbImportarProdutosOpcoes.Properties.Items[1].CheckState = CheckState.Unchecked;
            }
            else
            {
                cbImportarProdutosOpcoes.Properties.Items[0].CheckState = CheckState.Unchecked;
                cbImportarProdutosOpcoes.Properties.Items[1].CheckState = CheckState.Checked;
            }
            cbImportarProdutosOpcoes.Properties.Items[2].CheckState = (CheckState)Convert.ToInt16(implantacao.OpcoesImportar.Produtos.Secoes);
            cbImportarProdutosOpcoes.Properties.Items[3].CheckState = (CheckState)Convert.ToInt16(implantacao.OpcoesImportar.Produtos.Grupos);
            cbImportarProdutosOpcoes.Properties.Items[4].CheckState = (CheckState)Convert.ToInt16(implantacao.OpcoesImportar.Produtos.Subgrupos);
            cbImportarProdutosOpcoes.Properties.Items[5].CheckState = (CheckState)Convert.ToInt16(implantacao.OpcoesImportar.Produtos.Grades);
            cbImportarProdutosOpcoes.Properties.Items[5].CheckState = (CheckState)Convert.ToInt16(implantacao.OpcoesImportar.Produtos.Lotes);
            #endregion


        }

        private void UCImplantacao_Leave(object sender, EventArgs e)
        {
            SetImplantacaoJson(SalvaInformacoes(GetImplantacaoJson()));
        }

        private ImplantacaoJson SalvaInformacoes(ImplantacaoJson implantacao)
        {
            implantacao.RazaoCliente = txtCliente.Text;
            implantacao.Responsavel.Nome = txtResponsavel.Text;
            implantacao.SistemaAntigo = txtSistemaERP.Text;
            implantacao.LinkFormulario = new Uri(txtFormularioOriginal.Text);
            implantacao.LinkBackup = new Uri(txtBackupOriginal.Text);

            implantacao.RegimeEmpresa = rgRegime.SelectedIndex;
            implantacao.OpcoesImportar.Clientes = cbImportarClientes.SelectedIndex;
            implantacao.OpcoesImportar.Fornecedores = cbImportarFornecedores.SelectedIndex;
            implantacao.OpcoesImportar.ContasAPagar = cbImportarContasAPagar.SelectedIndex;
            implantacao.OpcoesImportar.ContasAReceber = cbImportarContasAReceber.SelectedIndex;
            implantacao.OpcoesImportar.Estoque = chkImportarEstoque.Checked;

            implantacao.OpcoesImportar.Produtos.Importar = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[0].CheckState);
            implantacao.OpcoesImportar.Produtos.Secoes = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[2].CheckState);
            implantacao.OpcoesImportar.Produtos.Grupos = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[3].CheckState);
            implantacao.OpcoesImportar.Produtos.Subgrupos = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[4].CheckState);
            implantacao.OpcoesImportar.Produtos.Grades = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[5].CheckState);
            implantacao.OpcoesImportar.Produtos.Lotes = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[6].CheckState);

            return implantacao;
        }
    }
}
