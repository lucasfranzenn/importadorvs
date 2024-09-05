using DevExpress.LookAndFeel;
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
            acUtilitarios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acUtilitariosBuscarColuna = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acUtilitariosVerificarUltimoRegistro = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acDrivers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acDriversMariaDB = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acDriversFirebird = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acDriversPostgree = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acDriversMSSQL = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acFiscal = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acFiscalICMS = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acFiscalPisCofins = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            blciTemas = new DevExpress.XtraBars.BarLinkContainerItem();
            skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            defaultLookAndFeel1 = new DefaultLookAndFeel(components);
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
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // fcPrincipal
            // 
            fcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            fcPrincipal.Location = new System.Drawing.Point(214, 31);
            fcPrincipal.Name = "fcPrincipal";
            fcPrincipal.Size = new System.Drawing.Size(556, 548);
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
            acPrincipal.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acGeral, acConexao, acImportacao, acUtilitarios, acDrivers, acFiscal });
            acPrincipal.Location = new System.Drawing.Point(0, 31);
            acPrincipal.Name = "acPrincipal";
            acPrincipal.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            acPrincipal.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            acPrincipal.Size = new System.Drawing.Size(214, 548);
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
            acGeralRelatorio.Text = "Relatório";
            // 
            // acExportarDados
            // 
            acExportarDados.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] { new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl) });
            acExportarDados.ImageOptions.SvgImage = Properties.Resources.exporttocsv;
            acExportarDados.Name = "acExportarDados";
            acExportarDados.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acExportarDados.Text = "Exportar Dados CSV";
            acExportarDados.Click += acExportarDados_Click;
            // 
            // acConexao
            // 
            acConexao.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acConexaoMyCommerce, acConexaoImportacao });
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
            // acImportacao
            // 
            acImportacao.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acImportacaoClientesForn, acImportacaoProdutos, acImportacaoProdutosST, acImportacaoContasAPagar, acImportacaoContasAReceber, acImportacaoPreVendas, acImportacaoServicos, acImportacaoGenerico, acImportacaoBackup });
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
            // 
            // acImportacaoBackup
            // 
            acImportacaoBackup.ImageOptions.SvgImage = Properties.Resources.exportfile;
            acImportacaoBackup.Name = "acImportacaoBackup";
            acImportacaoBackup.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoBackup.Text = "Backup";
            // 
            // acUtilitarios
            // 
            acUtilitarios.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acUtilitariosBuscarColuna, acUtilitariosVerificarUltimoRegistro });
            acUtilitarios.Expanded = true;
            acUtilitarios.Name = "acUtilitarios";
            acUtilitarios.Text = "Utilitários - Bancos";
            // 
            // acUtilitariosBuscarColuna
            // 
            acUtilitariosBuscarColuna.ImageOptions.SvgImage = Properties.Resources.actions_zoom;
            acUtilitariosBuscarColuna.Name = "acUtilitariosBuscarColuna";
            acUtilitariosBuscarColuna.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acUtilitariosBuscarColuna.Text = "Buscar Colunas";
            acUtilitariosBuscarColuna.Click += acUtilitariosBuscarColuna_Click;
            // 
            // acUtilitariosVerificarUltimoRegistro
            // 
            acUtilitariosVerificarUltimoRegistro.ImageOptions.SvgImage = Properties.Resources.last;
            acUtilitariosVerificarUltimoRegistro.Name = "acUtilitariosVerificarUltimoRegistro";
            acUtilitariosVerificarUltimoRegistro.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acUtilitariosVerificarUltimoRegistro.Text = "Verificar Ultimo Registro";
            // 
            // acDrivers
            // 
            acDrivers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acDriversMariaDB, acDriversFirebird, acDriversPostgree, acDriversMSSQL });
            acDrivers.Expanded = true;
            acDrivers.Name = "acDrivers";
            acDrivers.Text = "Drivers ODBC/Servidores";
            // 
            // acDriversMariaDB
            // 
            acDriversMariaDB.ImageOptions.Image = Properties.Resources.mariadb;
            acDriversMariaDB.Name = "acDriversMariaDB";
            acDriversMariaDB.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acDriversMariaDB.Text = "MariaDB";
            // 
            // acDriversFirebird
            // 
            acDriversFirebird.ImageOptions.Image = Properties.Resources.firebird;
            acDriversFirebird.Name = "acDriversFirebird";
            acDriversFirebird.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acDriversFirebird.Text = "Firebird";
            // 
            // acDriversPostgree
            // 
            acDriversPostgree.ImageOptions.Image = Properties.Resources.postgree;
            acDriversPostgree.Name = "acDriversPostgree";
            acDriversPostgree.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acDriversPostgree.Text = "Postgree";
            // 
            // acDriversMSSQL
            // 
            acDriversMSSQL.ImageOptions.Image = Properties.Resources.mssql;
            acDriversMSSQL.Name = "acDriversMSSQL";
            acDriversMSSQL.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acDriversMSSQL.Text = "MS-SQL/SQL Server";
            // 
            // acFiscal
            // 
            acFiscal.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acFiscalICMS, acFiscalPisCofins });
            acFiscal.Expanded = true;
            acFiscal.Name = "acFiscal";
            acFiscal.Text = "Auxiliar - Fiscal";
            // 
            // acFiscalICMS
            // 
            acFiscalICMS.ImageOptions.SvgImage = Properties.Resources.bo_price1;
            acFiscalICMS.Name = "acFiscalICMS";
            acFiscalICMS.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acFiscalICMS.Text = "CheatSheet ICMS";
            // 
            // acFiscalPisCofins
            // 
            acFiscalPisCofins.ImageOptions.SvgImage = Properties.Resources.accounting1;
            acFiscalPisCofins.Name = "acFiscalPisCofins";
            acFiscalPisCofins.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acFiscalPisCofins.Text = "CheatSheet Pis/Cofins";
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.Controls.Add(btnSair);
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { blciTemas, skinDropDownButtonItem1, skinPaletteDropDownButtonItem1 });
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new System.Drawing.Size(770, 31);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(blciTemas);
            // 
            // blciTemas
            // 
            blciTemas.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            blciTemas.Caption = "Temas";
            blciTemas.Id = 0;
            blciTemas.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, skinDropDownButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.Standard), new DevExpress.XtraBars.LinkPersistInfo(skinPaletteDropDownButtonItem1) });
            blciTemas.Name = "blciTemas";
            // 
            // skinDropDownButtonItem1
            // 
            skinDropDownButtonItem1.ActAsDropDown = true;
            skinDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinDropDownButtonItem1.Id = 1;
            skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            skinPaletteDropDownButtonItem1.ActAsDropDown = true;
            skinPaletteDropDownButtonItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            skinPaletteDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinPaletteDropDownButtonItem1.Id = 2;
            skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.AutoSaveInRegistry = true;
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { blciTemas, skinDropDownButtonItem1, skinPaletteDropDownButtonItem1 });
            fluentFormDefaultManager1.MaxItemId = 3;
            // 
            // defaultLookAndFeel1
            // 
            defaultLookAndFeel1.EnableBonusSkins = true;
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
            barDockControlBottom.Location = new System.Drawing.Point(0, 579);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(770, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 548);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(770, 31);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 548);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnSair;
            ClientSize = new System.Drawing.Size(770, 579);
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement acUtilitariosVerificarUltimoRegistro;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDrivers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDriversMariaDB;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDriversFirebird;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDriversPostgree;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDriversMSSQL;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acFiscal;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acFiscalICMS;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acFiscalPisCofins;
        private DevExpress.XtraBars.BarLinkContainerItem blciTemas;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acGeral;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acGeralImplantacao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acGeralRelatorio;
        private SimpleButton btnSair;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator acImportacaoSeparador;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acImportacaoBackup;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acExportarDados;
    }
}

