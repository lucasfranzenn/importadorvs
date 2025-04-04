﻿using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.CodedUISupport;
using System.IO;
using System.Windows.Controls;
using static Importador.Classes.Constantes;

namespace Importador
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            fcPrincipal = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            btnSair = new SimpleButton();
            acPrincipal = new DevExpress.XtraBars.Navigation.AccordionControl();
            acGeral = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acGeralImplantacao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acGeralRelatorio = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acExportarDados = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acConexao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acConexaoMyCommerce = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acConexaoImportacao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acConexaoLocal = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoClientesForn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoProdutos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoProdutosST = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoContasAPagar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoContasAReceber = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoPreVendas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoServicos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoGenerico = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoBackup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoValidacao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acImportacaoCentralizador = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acUtilitarios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acUtilitariosScriptSQL = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acUtilitariosPython = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acUtilitariosBuscarColuna = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acUtilitariosRecursos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            blciPreferencias = new DevExpress.XtraBars.BarLinkContainerItem();
            bbiOpcoes = new DevExpress.XtraBars.BarButtonItem();
            bsiTemas = new DevExpress.XtraBars.BarSubItem();
            skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            bsiTelaAtual = new DevExpress.XtraBars.BarStaticItem();
            lblImplantacao = new DevExpress.XtraBars.BarStaticItem();
            bsiOpcoes = new DevExpress.XtraBars.BarStaticItem();
            blciTemas = new DevExpress.XtraBars.BarLinkContainerItem();
            skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            repositoryItemBreadCrumbEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            skin = new DefaultLookAndFeel(components);
            acImportacaoSeparador = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)acPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            fluentDesignFormControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemBreadCrumbEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // fcPrincipal
            // 
            fcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            fcPrincipal.Location = new System.Drawing.Point(214, 31);
            fcPrincipal.Name = "fcPrincipal";
            fcPrincipal.Size = new System.Drawing.Size(556, 541);
            fcPrincipal.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Location = new System.Drawing.Point(0, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(0, 0);
            btnSair.TabIndex = 0;
            btnSair.Click += btnSair_Click;
            // 
            // acPrincipal
            // 
            acPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            acPrincipal.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acGeral, acConexao, acImportacao, acUtilitarios });
            acPrincipal.Location = new System.Drawing.Point(0, 31);
            acPrincipal.Name = "acPrincipal";
            acPrincipal.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            acPrincipal.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            acPrincipal.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            acPrincipal.Size = new System.Drawing.Size(214, 541);
            acPrincipal.TabIndex = 1;
            // 
            // acGeral
            // 
            acGeral.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acGeralImplantacao, acGeralRelatorio, acExportarDados });
            acGeral.Expanded = true;
            acGeral.Name = "acGeral";
            acGeral.Text = "Geral ";
            // 
            // acGeralImplantacao
            // 
            acGeralImplantacao.ImageOptions.SvgImage = Properties.Resources.edit;
            acGeralImplantacao.Name = "acGeralImplantacao";
            acGeralImplantacao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acGeralImplantacao.Text = "Implantação";
            acGeralImplantacao.Click += acGeralImplantacao_Click;
            // 
            // acGeralRelatorio
            // 
            acGeralRelatorio.ImageOptions.SvgImage = Properties.Resources.reportlayoutpivottable;
            acGeralRelatorio.Name = "acGeralRelatorio";
            acGeralRelatorio.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acGeralRelatorio.Text = "Gerar Relatório de Tempo Gasto";
            acGeralRelatorio.Click += acGeralRelatorio_Click;
            // 
            // acExportarDados
            // 
            acExportarDados.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] { new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl) });
            acExportarDados.ImageOptions.SvgImage = Properties.Resources.exporttocsv;
            acExportarDados.Name = "acExportarDados";
            acExportarDados.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acExportarDados.Text = "Exportar Dados CSV";
            acExportarDados.Visible = false;
            acExportarDados.Click += acExportarDados_Click;
            // 
            // acConexao
            // 
            acConexao.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acConexaoMyCommerce, acConexaoImportacao, acConexaoLocal });
            acConexao.Expanded = true;
            acConexao.Name = "acConexao";
            acConexao.Text = "Conexão";
            // 
            // acConexaoMyCommerce
            // 
            acConexaoMyCommerce.ImageOptions.Image = Properties.Resources.mycommerce;
            acConexaoMyCommerce.Name = "acConexaoMyCommerce";
            acConexaoMyCommerce.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acConexaoMyCommerce.Text = "MyCommerce";
            acConexaoMyCommerce.Click += acConexaoMyCommerce_Click;
            // 
            // acConexaoImportacao
            // 
            acConexaoImportacao.ImageOptions.SvgImage = Properties.Resources.import;
            acConexaoImportacao.Name = "acConexaoImportacao";
            acConexaoImportacao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acConexaoImportacao.Text = "Importação";
            acConexaoImportacao.Click += acConexaoImportacao_Click;
            // 
            // acConexaoLocal
            // 
            acConexaoLocal.ImageOptions.SvgImage = Properties.Resources.bo_address;
            acConexaoLocal.Name = "acConexaoLocal";
            acConexaoLocal.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acConexaoLocal.Text = "Local";
            acConexaoLocal.Click += acConexaoLocal_Click;
            // 
            // acImportacao
            // 
            acImportacao.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acImportacaoClientesForn, acImportacaoProdutos, acImportacaoProdutosST, acImportacaoContasAPagar, acImportacaoContasAReceber, acImportacaoPreVendas, acImportacaoServicos, acImportacaoGenerico, acImportacaoBackup, acImportacaoValidacao, acImportacaoCentralizador });
            acImportacao.Expanded = true;
            acImportacao.Name = "acImportacao";
            acImportacao.Text = "Importação";
            // 
            // acImportacaoClientesForn
            // 
            acImportacaoClientesForn.ImageOptions.SvgImage = Properties.Resources.bo_department;
            acImportacaoClientesForn.Name = "acImportacaoClientesForn";
            acImportacaoClientesForn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoClientesForn.Text = "Clientes/Fornecedores";
            acImportacaoClientesForn.Click += acImportacaoClientesForn_Click;
            // 
            // acImportacaoProdutos
            // 
            acImportacaoProdutos.ImageOptions.SvgImage = Properties.Resources.products;
            acImportacaoProdutos.Name = "acImportacaoProdutos";
            acImportacaoProdutos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoProdutos.Text = "Produtos";
            acImportacaoProdutos.Click += acImportacaoProdutos_Click;
            // 
            // acImportacaoProdutosST
            // 
            acImportacaoProdutosST.ImageOptions.SvgImage = Properties.Resources.business_dollar;
            acImportacaoProdutosST.Name = "acImportacaoProdutosST";
            acImportacaoProdutosST.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoProdutosST.Text = "Produtos ST";
            acImportacaoProdutosST.Click += acImportacaoProdutosST_Click;
            // 
            // acImportacaoContasAPagar
            // 
            acImportacaoContasAPagar.ImageOptions.SvgImage = Properties.Resources.shopping_wallet;
            acImportacaoContasAPagar.Name = "acImportacaoContasAPagar";
            acImportacaoContasAPagar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoContasAPagar.Text = "Contas a Pagar";
            acImportacaoContasAPagar.Click += acImportacaoContasAPagar_Click;
            // 
            // acImportacaoContasAReceber
            // 
            acImportacaoContasAReceber.ImageOptions.SvgImage = Properties.Resources.financial;
            acImportacaoContasAReceber.Name = "acImportacaoContasAReceber";
            acImportacaoContasAReceber.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoContasAReceber.Text = "Contas a Receber";
            acImportacaoContasAReceber.Click += acImportacaoContasAReceber_Click;
            // 
            // acImportacaoPreVendas
            // 
            acImportacaoPreVendas.ImageOptions.SvgImage = Properties.Resources.productorderdetail_21;
            acImportacaoPreVendas.Name = "acImportacaoPreVendas";
            acImportacaoPreVendas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoPreVendas.Text = "Pré-Vendas";
            acImportacaoPreVendas.Visible = false;
            acImportacaoPreVendas.Click += acImportacaoPreVendas_Click;
            // 
            // acImportacaoServicos
            // 
            acImportacaoServicos.ImageOptions.SvgImage = Properties.Resources.initialstate;
            acImportacaoServicos.Name = "acImportacaoServicos";
            acImportacaoServicos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoServicos.Text = "Serviços";
            acImportacaoServicos.Click += acImportacaoServicos_Click;
            // 
            // acImportacaoGenerico
            // 
            acImportacaoGenerico.ImageOptions.SvgImage = Properties.Resources.bo_report;
            acImportacaoGenerico.Name = "acImportacaoGenerico";
            acImportacaoGenerico.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoGenerico.Text = "Genérico/Outros";
            acImportacaoGenerico.Click += acImportacaoGenerico_Click;
            // 
            // acImportacaoBackup
            // 
            acImportacaoBackup.ImageOptions.SvgImage = Properties.Resources.exportfile;
            acImportacaoBackup.Name = "acImportacaoBackup";
            acImportacaoBackup.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoBackup.Text = "Backup";
            acImportacaoBackup.Click += acImportacaoBackup_Click;
            // 
            // acImportacaoValidacao
            // 
            acImportacaoValidacao.ImageOptions.Image = Properties.Resources.showtestreport_16x16;
            acImportacaoValidacao.Name = "acImportacaoValidacao";
            acImportacaoValidacao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoValidacao.Text = "Validações";
            acImportacaoValidacao.Click += acImportacaoValidacao_Click;
            // 
            // acImportacaoCentralizador
            // 
            acImportacaoCentralizador.ImageOptions.SvgImage = Properties.Resources.business_diagram;
            acImportacaoCentralizador.Name = "acImportacaoCentralizador";
            acImportacaoCentralizador.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoCentralizador.Text = "Centralizador de Empresas";
            acImportacaoCentralizador.Click += acImportacaoCentralizador_Click;
            // 
            // acUtilitarios
            // 
            acUtilitarios.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acUtilitariosScriptSQL, acUtilitariosPython, acUtilitariosBuscarColuna, acUtilitariosRecursos });
            acUtilitarios.Expanded = true;
            acUtilitarios.Name = "acUtilitarios";
            acUtilitarios.Text = "Utilitários";
            // 
            // acUtilitariosScriptSQL
            // 
            acUtilitariosScriptSQL.ImageOptions.Image = Properties.Resources.scripts_16x161;
            acUtilitariosScriptSQL.Name = "acUtilitariosScriptSQL";
            acUtilitariosScriptSQL.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acUtilitariosScriptSQL.Text = "Script SQL";
            acUtilitariosScriptSQL.Click += acUtilitariosScriptSQL_Click;
            // 
            // acUtilitariosPython
            // 
            acUtilitariosPython.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("acUtilitariosPython.ImageOptions.Image");
            acUtilitariosPython.Name = "acUtilitariosPython";
            acUtilitariosPython.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acUtilitariosPython.Text = "Scripts Python";
            acUtilitariosPython.Click += acUtilitariosPython_Click;
            // 
            // acUtilitariosBuscarColuna
            // 
            acUtilitariosBuscarColuna.ImageOptions.SvgImage = Properties.Resources.actions_zoom;
            acUtilitariosBuscarColuna.Name = "acUtilitariosBuscarColuna";
            acUtilitariosBuscarColuna.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acUtilitariosBuscarColuna.Text = "Buscar Colunas";
            acUtilitariosBuscarColuna.Click += acUtilitariosBuscarColuna_Click;
            // 
            // acUtilitariosRecursos
            // 
            acUtilitariosRecursos.ImageOptions.SvgImage = Properties.Resources.functionsinformation;
            acUtilitariosRecursos.Name = "acUtilitariosRecursos";
            acUtilitariosRecursos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            toolTipItem3.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipItem3.ImageOptions.SvgImage = Properties.Resources.functionsinformation;
            toolTipItem3.Text = "Recursos de apoio para facilitar a importação.\r\nEstá incluso: \r\n * Nomenclaturas de colunas;\r\n * Validações Fiscais;\r\n * Sistemas Importados;\r\n * Software Úteis;\r\n * Dicas de Bancos de Dados.";
            superToolTip3.Items.Add(toolTipItem3);
            acUtilitariosRecursos.SuperTip = superToolTip3;
            acUtilitariosRecursos.Text = "Recursos de Apoio";
            acUtilitariosRecursos.Click += acUtilitariosAuxiliar_Click;
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.Controls.Add(btnSair);
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { blciPreferencias, bsiTelaAtual, lblImplantacao, bsiOpcoes, blciTemas, bbiOpcoes, bsiTemas, skinBarSubItem1, skinDropDownButtonItem1, skinPaletteDropDownButtonItem1 });
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemComboBox1, repositoryItemBreadCrumbEdit1, repositoryItemButtonEdit1 });
            fluentDesignFormControl1.Size = new System.Drawing.Size(770, 31);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(blciPreferencias);
            fluentDesignFormControl1.TitleItemLinks.Add(bsiTelaAtual);
            fluentDesignFormControl1.TitleItemLinks.Add(lblImplantacao);
            // 
            // blciPreferencias
            // 
            blciPreferencias.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            blciPreferencias.Caption = "Preferências";
            blciPreferencias.Id = 0;
            blciPreferencias.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(bbiOpcoes), new DevExpress.XtraBars.LinkPersistInfo(bsiTemas) });
            blciPreferencias.Name = "blciPreferencias";
            // 
            // bbiOpcoes
            // 
            bbiOpcoes.Caption = "Opções";
            bbiOpcoes.Id = 14;
            bbiOpcoes.ImageOptions.SvgImage = Properties.Resources.properties;
            bbiOpcoes.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10);
            bbiOpcoes.Name = "bbiOpcoes";
            bbiOpcoes.ItemClick += bbiOpcoes_ItemClick;
            // 
            // bsiTemas
            // 
            bsiTemas.Caption = "Temas";
            bsiTemas.Id = 15;
            bsiTemas.ImageOptions.Image = Properties.Resources.loadtheme_16x16;
            bsiTemas.ImageOptions.LargeImage = Properties.Resources.loadtheme_32x32;
            bsiTemas.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(skinDropDownButtonItem1), new DevExpress.XtraBars.LinkPersistInfo(skinPaletteDropDownButtonItem1) });
            bsiTemas.Name = "bsiTemas";
            // 
            // skinDropDownButtonItem1
            // 
            skinDropDownButtonItem1.ActAsDropDown = true;
            skinDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinDropDownButtonItem1.Id = 18;
            skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            skinPaletteDropDownButtonItem1.ActAsDropDown = true;
            skinPaletteDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinPaletteDropDownButtonItem1.Id = 20;
            skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // bsiTelaAtual
            // 
            bsiTelaAtual.Id = 3;
            bsiTelaAtual.Name = "bsiTelaAtual";
            // 
            // lblImplantacao
            // 
            lblImplantacao.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            lblImplantacao.Caption = "Imp. ";
            lblImplantacao.Id = 4;
            lblImplantacao.Name = "lblImplantacao";
            // 
            // bsiOpcoes
            // 
            bsiOpcoes.Caption = "Opções";
            bsiOpcoes.Id = 12;
            bsiOpcoes.ImageOptions.SvgImage = Properties.Resources.properties;
            bsiOpcoes.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5);
            bsiOpcoes.Name = "bsiOpcoes";
            bsiOpcoes.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // blciTemas
            // 
            blciTemas.Caption = "Temas";
            blciTemas.Id = 13;
            blciTemas.Name = "blciTemas";
            // 
            // skinBarSubItem1
            // 
            skinBarSubItem1.Caption = "skinBarSubItem1";
            skinBarSubItem1.Id = 17;
            skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.AutoSaveInRegistry = true;
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { blciPreferencias, bsiTelaAtual, lblImplantacao, bsiOpcoes, blciTemas, bbiOpcoes, bsiTemas, skinBarSubItem1, skinDropDownButtonItem1, skinPaletteDropDownButtonItem1 });
            fluentFormDefaultManager1.MaxItemId = 21;
            fluentFormDefaultManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemComboBox1, repositoryItemBreadCrumbEdit1, repositoryItemButtonEdit1 });
            // 
            // repositoryItemComboBox1
            // 
            repositoryItemComboBox1.AutoHeight = false;
            repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemBreadCrumbEdit1
            // 
            repositoryItemBreadCrumbEdit1.AutoHeight = false;
            repositoryItemBreadCrumbEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemBreadCrumbEdit1.Name = "repositoryItemBreadCrumbEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // skin
            // 
            skin.EnableBonusSkins = true;
            // 
            // acImportacaoSeparador
            // 
            acImportacaoSeparador.Height = 1;
            acImportacaoSeparador.Name = "acImportacaoSeparador";
            // 
            // barManager1
            // 
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 31);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(770, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 572);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(770, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 541);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(770, 31);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 541);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnSair;
            ClientSize = new System.Drawing.Size(770, 572);
            ControlContainer = fcPrincipal;
            Controls.Add(fcPrincipal);
            Controls.Add(acPrincipal);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            FormBorderEffect = FormBorderEffect.Shadow;
            IconOptions.Image = Properties.Resources.refresh_32x32;
            IconOptions.LargeImage = Properties.Resources.refresh_32x32;
            MinimumSize = new System.Drawing.Size(758, 573);
            Name = "frmPrincipal";
            NavigationControl = acPrincipal;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Importador de Dados - MyCommerce";
            FormClosing += frmPrincipal_FormClosing;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)acPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            fluentDesignFormControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemBreadCrumbEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fcPrincipal;
        private DevExpress.XtraBars.Navigation.AccordionControl acPrincipal;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acConexao;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acConexaoMyCommerce;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acConexaoImportacao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoClientesForn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoProdutos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoProdutosST;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoContasAPagar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoContasAReceber;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoPreVendas;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoServicos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoGenerico;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acUtilitarios;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acUtilitariosBuscarColuna;
        private DevExpress.XtraBars.BarLinkContainerItem blciPreferencias;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acGeral;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acGeralImplantacao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acGeralRelatorio;
        private SimpleButton btnSair;
        private DevExpress.LookAndFeel.DefaultLookAndFeel skin;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator acImportacaoSeparador;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoBackup;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acExportarDados;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acConexaoLocal;
        private DevExpress.XtraBars.BarStaticItem bsiTelaAtual;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acUtilitariosRecursos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoValidacao;
        private DevExpress.XtraBars.BarStaticItem lblImplantacao;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoCentralizador;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acUtilitariosScriptSQL;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acUtilitariosPython;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.BarStaticItem bsiOpcoes;
        private DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit repositoryItemBreadCrumbEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.BarLinkContainerItem blciTemas;
        private DevExpress.XtraBars.BarButtonItem bbiOpcoes;
        private DevExpress.XtraBars.BarSubItem bsiTemas;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
    }
}

