using DevExpress.XtraEditors;
using DevExpress.XtraEditors.CodedUISupport;
using System.Windows.Controls;

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
            defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
            acImportacaoSeparador = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            bar2 = new DevExpress.XtraBars.Bar();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            fcPrincipal.Location = new System.Drawing.Point(214, 72);
            fcPrincipal.Name = "fcPrincipal";
            fcPrincipal.Size = new System.Drawing.Size(542, 480);
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
            acPrincipal.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acGeral, acConexao, acImportacao, acUtilitarios, acDrivers, acFiscal, accordionControlElement1 });
            acPrincipal.Location = new System.Drawing.Point(0, 72);
            acPrincipal.Name = "acPrincipal";
            acPrincipal.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            acPrincipal.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            acPrincipal.Size = new System.Drawing.Size(214, 480);
            acPrincipal.TabIndex = 1;
            // 
            // acGeral
            // 
            acGeral.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acGeralImplantacao, acGeralRelatorio });
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
            // 
            // acConexaoImportacao
            // 
            acConexaoImportacao.ImageOptions.SvgImage = Properties.Resources.import;
            acConexaoImportacao.Name = "acConexaoImportacao";
            acConexaoImportacao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acConexaoImportacao.Text = "Importação";
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
            // 
            // acImportacaoProdutosST
            // 
            acImportacaoProdutosST.ImageOptions.SvgImage = Properties.Resources.business_dollar;
            acImportacaoProdutosST.Name = "acImportacaoProdutosST";
            acImportacaoProdutosST.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoProdutosST.Text = "Produtos ST";
            // 
            // acImportacaoContasAPagar
            // 
            acImportacaoContasAPagar.ImageOptions.SvgImage = Properties.Resources.shopping_wallet;
            acImportacaoContasAPagar.Name = "acImportacaoContasAPagar";
            acImportacaoContasAPagar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoContasAPagar.Text = "Contas a Pagar";
            // 
            // acImportacaoContasAReceber
            // 
            acImportacaoContasAReceber.ImageOptions.SvgImage = Properties.Resources.financial;
            acImportacaoContasAReceber.Name = "acImportacaoContasAReceber";
            acImportacaoContasAReceber.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoContasAReceber.Text = "Contas a Receber";
            // 
            // acImportacaoPreVendas
            // 
            acImportacaoPreVendas.ImageOptions.SvgImage = Properties.Resources.productorderdetail_21;
            acImportacaoPreVendas.Name = "acImportacaoPreVendas";
            acImportacaoPreVendas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoPreVendas.Text = "Pré-Vendas";
            // 
            // acImportacaoServicos
            // 
            acImportacaoServicos.ImageOptions.SvgImage = Properties.Resources.initialstate;
            acImportacaoServicos.Name = "acImportacaoServicos";
            acImportacaoServicos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acImportacaoServicos.Text = "Serviços";
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
            fluentDesignFormControl1.Size = new System.Drawing.Size(756, 31);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(blciTemas);
            // 
            // blciTemas
            // 
            blciTemas.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            blciTemas.Caption = "Temas";
            blciTemas.Id = 0;
            blciTemas.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(skinDropDownButtonItem1), new DevExpress.XtraBars.LinkPersistInfo(skinPaletteDropDownButtonItem1) });
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
            // acImportacaoSeparador
            // 
            acImportacaoSeparador.Height = 1;
            acImportacaoSeparador.Name = "acImportacaoSeparador";
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.MainMenu = bar2;
            barManager1.StatusBar = bar3;
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 1;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.Text = "Tools";
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 31);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(756, 41);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 552);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(756, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 72);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 480);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(756, 72);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 480);
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement2 });
            accordionControlElement1.Expanded = true;
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "Validação de Dados";
            // 
            // accordionControlElement2
            // 
            accordionControlElement2.Name = "accordionControlElement2";
            accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement2.Text = "Dados Base";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnSair;
            ClientSize = new System.Drawing.Size(756, 572);
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
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
    }
}

