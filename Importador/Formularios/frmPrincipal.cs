﻿using DevExpress.DataAccess.Sql;
using DevExpress.Printing.Core.NativePdfExport;
using FastReport;
using FastReport.Export.PdfSimple;
using FastReport.Data;
using Importador.Classes;
using Importador.Conexao;
using Importador.Formularios;
using Importador.Properties;
using Importador.UserControls.BaseControls;
using Importador.UserControls.Conexao;
using Importador.UserControls.Geral;
using Importador.UserControls.Importacao;
using Importador.UserControls.Utilitarios;
using Microsoft.Data.Sqlite;
using System;
using System.Data;
using static Importador.Classes.Utils;
using UC = Importador.UserControls;
using DevExpress.XtraEditors;

namespace Importador
{
    public partial class frmPrincipal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public static UCBase ucAtual;
        public static frmRecursos frmRecursos;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void acGeralImplantacao_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCImplantacao) return;
            ucAtual = new UCImplantacao();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Implantação";
        }

        private void acExportarDados_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCExportarDados) return;
            ucAtual = new UCExportarDados();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Exportar Dados CSV";
        }

        public void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acImportacaoClientesForn_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCClientes) return;
            ucAtual = new UCClientes();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Importação de Clientes e Fornecedores";
        }

        private void acConexaoMyCommerce_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCConexaoMyCommerce) return;
            ucAtual = new UCConexaoMyCommerce();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Configuração de Conexão com MyCommerce";
        }

        private void acConexaoImportacao_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCConexaoImportacao) return;
            ucAtual = new UCConexaoImportacao();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Configuração de Conexão com Banco Importação";
        }

        private void acImportacaoProdutos_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCProdutos) return;
            ucAtual = new UCProdutos();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Importação de Produtos";
        }

        private void frmPrincipal_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Properties.Configuracoes.Default.NomeSkin = skin.LookAndFeel.SkinName;
            Properties.Configuracoes.Default.PaletaSkin = skin.LookAndFeel.ActiveSvgPaletteName;
            Properties.Configuracoes.Default.Save();
        }

        private void acUtilitariosBuscarColuna_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCBuscaColuna) return;
            ucAtual = new UCBuscaColuna();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Buscar coluna no Banco Importação";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            skin.LookAndFeel.SetSkinStyle(Properties.Configuracoes.Default.NomeSkin, Properties.Configuracoes.Default.PaletaSkin);
            skin.LookAndFeel.UseDefaultLookAndFeel = true;

            Configuracoes.Default.UsuarioLogado = GetUsuarioSID();
        }

        private void acImportacaoProdutosST_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCProdutosST) return;
            ucAtual = new UCProdutosST();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Importação de ST dos Produtos";
        }

        private void acImportacaoContasAPagar_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCContasAPagar) return;
            ucAtual = new UCContasAPagar();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Importação das Contas a Pagar";
        }

        private void acImportacaoContasAReceber_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCContasAReceber) return;
            ucAtual = new UCContasAReceber();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Importação das Contas a Receber";
        }

        private void acImportacaoPreVendas_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCClientes) return;
            ucAtual = new UCClientes();

            AlteraAba(ref fcPrincipal, new UC.Importacao.UCPreVendas());
            bsiTelaAtual.Caption = "Importação das Pré-Vendas";
        }

        private void acImportacaoServicos_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCServicos) return;
            ucAtual = new UCServicos();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Importação dos Serviços";
        }

        private void acConexaoLocal_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCConexaoLocal) return;
            ucAtual = new UCConexaoLocal();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Configuração da Conexão com o Banco Local do Importador";
        }

        private void acImportacaoBackup_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCBackup) return;
            ucAtual = new UCBackup();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Salvar Backup";
        }

        private void acImportacaoGenerico_Click(object sender, EventArgs e)
        {
            if (ucAtual is UCGenerico) return;
            ucAtual = new UCGenerico();

            AlteraAba(ref fcPrincipal, ucAtual);
            bsiTelaAtual.Caption = "Importação de tabelas genéricas";
        }

        private void acUtilitariosAuxiliar_Click(object sender, EventArgs e)
        {
            frmRecursos = new();
            frmRecursos.Disposed += (sender, args) => Show();
            Hide();
            frmRecursos.Show();
        }

        private void acGeralRelatorio_Click(object sender, EventArgs e)
        {
            Relatorios.GerarRelatorio();

            if(XtraMessageBox.Show("Relatório Gerado\nDeseja abrir na pasta?", "..::Importador::..", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                System.Diagnostics.Process.Start("explorer.exe", $"/select, \"Relatorios\\Implantação {Configuracoes.Default.CodigoImplantacao}.pdf\"");
        }
    }
}
