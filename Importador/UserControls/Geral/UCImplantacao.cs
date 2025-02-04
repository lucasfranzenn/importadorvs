using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Classes.Entidades;
using Importador.Classes.Entidades.RetornoAPI;
using Importador.Conexao;
using Importador.Properties;
using Importador.UserControls.BaseControls;
using Importador.UserControls.Componentes;
using System;
using System.Windows.Forms;
using static Importador.Classes.Constantes;
using static Importador.Properties.Configuracoes;

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
            Implantacao impAtual = ConexaoBancoImportador.GetEntidade<Implantacao>(Enums.TabelaBancoLocal.implantacoes);

            if (impAtual is null) return;

            CarregaInformacoes(impAtual);
        }

        private void UCImplantacao_Leave(object sender, EventArgs e)
        {
            SalvaInformacoes();
        }

        private void SalvaInformacoes()
        {
            Implantacao implantacao = ConexaoBancoImportador.GetEntidade<Implantacao>(Enums.TabelaBancoLocal.implantacoes);

            if (implantacao is null) return;

            #region Informações da Implantação
            implantacao.RazaoSocialCliente = txtCliente.Text;
            implantacao.NomeResponsavel = txtResponsavel.Text;
            implantacao.SistemaAntigo = txtSistemaERP.Text;
            implantacao.BancoDeDados = txtSGBD.Text;
            implantacao.LinkFormulario = txtFormularioOriginal.Text;
            implantacao.LinkBackup = txtBackupOriginal.Text;
            implantacao.RegimeEmpresa = rgRegime.SelectedIndex;
            implantacao.Workflow = txtWorkflow.Text;
            implantacao.Empresa = Convert.ToInt32(Configuracoes.Default.Empresa);
            #endregion

            #region Informações a serem importadas
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
            #endregion

            ConexaoBancoImportador.Update(implantacao, Enums.TabelaBancoLocal.implantacoes);

            Default.RegimeEmpresa = rgRegime.SelectedIndex;
            Default.Save();
        }

        private void txtCodigoImplantacao_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoImplantacao.Text))
            {
                Default.CodigoImplantacao = txtCodigoImplantacao.Text;
                Default.Empresa = string.IsNullOrEmpty(txtEmpresa.Text) ? "1" : txtEmpresa.Text;
                Default.Save();
                var impAtual = ConexaoBancoImportador.GetEntidade<Implantacao>(Enums.TabelaBancoLocal.implantacoes);

                if (impAtual is not null)
                {
                    CarregaInformacoes(impAtual);
                    return;
                }

                CriarNovaImplantacao(impAtual);
            }
        }

        private async void CriarNovaImplantacao(Implantacao impAtual)
        {
            var waitform = new Aguarde("Consumindo api...");
            var formpai = FindForm();

            waitform.Location = new System.Drawing.Point(
                    formpai.Location.X + (formpai.Width - waitform.Width) / 2,
                    formpai.Location.Y + (formpai.Height - waitform.Height) / 2
                );

            waitform.Show(formpai);

            JiraIssue issues = await ConsumirApi.GetIssueOnJira(txtCodigoImplantacao.Text);

            waitform.Dispose();


            if (issues is not null)
            {
                ConexaoBancoImportador.InserirRegistro(new Implantacao(issues), Enums.TabelaBancoLocal.implantacoes);
                impAtual = ConexaoBancoImportador.GetEntidade<Implantacao>(Enums.TabelaBancoLocal.implantacoes);
            }
            else
            {
                if (XtraMessageBox.Show("Este código não está cadastrado\nDeseja cadastrar?", "..::Importador::..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConexaoBancoImportador.InserirRegistro(new Implantacao(txtCodigoImplantacao.Text), Enums.TabelaBancoLocal.implantacoes);
                    impAtual = ConexaoBancoImportador.GetEntidade<Implantacao>(Enums.TabelaBancoLocal.implantacoes);
                }
                else return;
            }

            CarregaInformacoes(impAtual);
        }

        private void CarregaInformacoes(Implantacao implantacao)
        {
            #region Setar Informações do Cliente/Responsável
            txtCodigoImplantacao.Text = implantacao.CodigoImplantacao.ToString();
            txtEmpresa.Text = implantacao.Empresa.ToString();
            txtCliente.Text = implantacao.RazaoSocialCliente;
            txtResponsavel.Text = $"{implantacao.NomeResponsavel}";
            txtSistemaERP.Text = implantacao.SistemaAntigo;
            txtSGBD.Text = implantacao.BancoDeDados;
            txtFormularioOriginal.Text = implantacao.LinkFormulario.ToString();
            txtBackupOriginal.Text = implantacao.LinkBackup.ToString();
            txtWorkflow.Text = implantacao.Workflow;
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

        private void txtResponsavel_Enter(object sender, EventArgs e)
        {
            var cmd = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            cmd.CommandText = "select distinct(nomeresponsavel) from implantacoes where nomeresponsavel is not null";

            txtResponsavel.Properties.AdvancedModeOptions.AutoCompleteCustomSource = Utils.GetAutoCompleteCustomSource(cmd);
        }

        private void txtSGBD_Enter(object sender, EventArgs e)
        {
            var cmd = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            cmd.CommandText = "select distinct(BancoDeDados) from implantacoes where BancoDeDados is not null";

            txtSGBD.Properties.AdvancedModeOptions.AutoCompleteCustomSource = Utils.GetAutoCompleteCustomSource(cmd);
        }

        private void txtSistemaERP_Enter(object sender, EventArgs e)
        {
            var cmd = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            cmd.CommandText = "select distinct(SistemaAntigo) from implantacoes where SistemaAntigo is not null";

            txtSistemaERP.Properties.AdvancedModeOptions.AutoCompleteCustomSource = Utils.GetAutoCompleteCustomSource(cmd);
        }
    }
}
