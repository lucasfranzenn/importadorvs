using DevExpress.XtraEditors;
using Importador.Classes;
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
using static Importador.Classes.Utils;
using static Importador.Properties.Configuracoes;
using static Importador.Classes.Constantes;

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
            try
            {
                CarregaInformacoes(ConexaoBancoImportador.GetEntidade<Implantacao>(Enums.TabelaBancoLocal.implantacoes));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "..::Importador::..");
            }
        }

        private void UCImplantacao_Leave(object sender, EventArgs e)
        {
            SalvaInformacoes();
        }

        private void SalvaInformacoes()
        {
            Implantacao implantacao = ConexaoBancoImportador.GetEntidade<Implantacao>(Enums.TabelaBancoLocal.implantacoes);

            implantacao.RazaoSocialCliente = txtCliente.Text;
            implantacao.NomeResponsavel = txtResponsavel.Text;
            implantacao.SistemaAntigo = txtSistemaERP.Text;
            implantacao.LinkFormulario = txtFormularioOriginal.Text;
            implantacao.LinkBackup = txtBackupOriginal.Text;

            implantacao.RegimeEmpresa = rgRegime.SelectedIndex;
            implantacao.ImportarClientes = ((byte)cbImportarClientes.SelectedIndex);
            implantacao.ImportarFornecedores = ((byte)cbImportarFornecedores.SelectedIndex);
            implantacao.ImportarContasAPagar = ((byte)cbImportarContasAPagar.SelectedIndex);
            implantacao.ImportarContasAReceber = ((byte)cbImportarContasAReceber.SelectedIndex);
            implantacao.ImportarEstoque = chkImportarEstoque.Checked;

            implantacao.ImportarProdutos = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[0].CheckState);
            implantacao.ImportarSecoes = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[2].CheckState);
            implantacao.ImportarGrupos = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[3].CheckState);
            implantacao.ImportarSubGrupos = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[4].CheckState);
            implantacao.ImportarFabricantes = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[5].CheckState);
            implantacao.ImportarGrades = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[6].CheckState);
            implantacao.ImportarLotes = Convert.ToBoolean((int)cbImportarProdutosOpcoes.Properties.Items[7].CheckState);

            ConexaoBancoImportador.Update(implantacao, Enums.TabelaBancoLocal.implantacoes);
        }

        private void txtCodigoImplantacao_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoImplantacao.Text))
            {
                Default.CodigoImplantacao = txtCodigoImplantacao.Text;
                Default.Save();
                try
                {
                    CarregaInformacoes(ConexaoBancoImportador.GetEntidade<Implantacao>(Enums.TabelaBancoLocal.implantacoes));
                }
                catch (Exception)
                {
                    if(XtraMessageBox.Show("Este código não está cadastrado\nDeseja cadastrar?", "..::Importador::..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ConexaoBancoImportador.InserirRegistro(new Implantacao(txtCodigoImplantacao.Text), Enums.TabelaBancoLocal.implantacoes);

                    }
                }
            }
        }

        private void CarregaInformacoes(Implantacao implantacao)
        {
            #region Setar Informações do Cliente/Responsável
            txtCodigoImplantacao.Text = implantacao.CodigoImplantacao.ToString();
            txtCliente.Text = implantacao.RazaoSocialCliente;
            txtResponsavel.Text = $"{implantacao.NomeResponsavel}";
            txtSistemaERP.Text = implantacao.SistemaAntigo;
            txtFormularioOriginal.Text = implantacao.LinkFormulario.ToString();
            txtBackupOriginal.Text = implantacao.LinkBackup.ToString();
            #endregion

            #region Setar Informações de importação
            rgRegime.SelectedIndex = Convert.ToInt16(implantacao.RegimeEmpresa);
            cbImportarClientes.SelectedIndex = Convert.ToInt16(implantacao.ImportarClientes);
            cbImportarFornecedores.SelectedIndex = Convert.ToInt16(implantacao.ImportarFornecedores);
            cbImportarContasAPagar.SelectedIndex = Convert.ToInt16(implantacao.ImportarContasAPagar);
            cbImportarContasAReceber.SelectedIndex = Convert.ToInt16(implantacao.ImportarContasAReceber);
            chkImportarEstoque.Checked = implantacao.ImportarEstoque;
            #endregion

            #region Setar Importação dos Produtos
            if (implantacao.ImportarProdutos)
            {
                cbImportarProdutosOpcoes.Properties.Items[0].CheckState = CheckState.Checked;
                cbImportarProdutosOpcoes.Properties.Items[1].CheckState = CheckState.Unchecked;
            }
            else
            {
                cbImportarProdutosOpcoes.Properties.Items[0].CheckState = CheckState.Unchecked;
                cbImportarProdutosOpcoes.Properties.Items[1].CheckState = CheckState.Checked;
            }
            cbImportarProdutosOpcoes.Properties.Items[2].CheckState = (CheckState)Convert.ToInt16(implantacao.ImportarSecoes);
            cbImportarProdutosOpcoes.Properties.Items[3].CheckState = (CheckState)Convert.ToInt16(implantacao.ImportarGrupos);
            cbImportarProdutosOpcoes.Properties.Items[4].CheckState = (CheckState)Convert.ToInt16(implantacao.ImportarSubGrupos);
            cbImportarProdutosOpcoes.Properties.Items[5].CheckState = (CheckState)Convert.ToInt16(implantacao.ImportarFabricantes);
            cbImportarProdutosOpcoes.Properties.Items[6].CheckState = (CheckState)Convert.ToInt16(implantacao.ImportarGrades);
            cbImportarProdutosOpcoes.Properties.Items[7].CheckState = (CheckState)Convert.ToInt16(implantacao.ImportarLotes);
            #endregion
        }
    }
}
