﻿namespace Importador.UserControls.Geral
{
    partial class UCImplantacao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCliente = new DevExpress.XtraEditors.LabelControl();
            lblResponsavel = new DevExpress.XtraEditors.LabelControl();
            tpOpcoesImportar = new DevExpress.Utils.Layout.TablePanel();
            lblImportarClientes = new DevExpress.XtraEditors.LabelControl();
            chkImportarEstoque = new DevExpress.XtraEditors.CheckEdit();
            cbImportarContasAReceber = new DevExpress.XtraEditors.ComboBoxEdit();
            cbImportarContasAPagar = new DevExpress.XtraEditors.ComboBoxEdit();
            cbImportarFornecedores = new DevExpress.XtraEditors.ComboBoxEdit();
            cbImportarClientes = new DevExpress.XtraEditors.ComboBoxEdit();
            cbImportarProdutosOpcoes = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            lblSistemaERP = new DevExpress.XtraEditors.LabelControl();
            lblFormularioOriginal = new DevExpress.XtraEditors.LabelControl();
            lblBackupOriginal = new DevExpress.XtraEditors.LabelControl();
            rgRegime = new DevExpress.XtraEditors.RadioGroup();
            tpImplantacao = new DevExpress.Utils.Layout.TablePanel();
            txtBackupOriginal = new DevExpress.XtraEditors.HyperLinkEdit();
            txtFormularioOriginal = new DevExpress.XtraEditors.HyperLinkEdit();
            txtSistemaERP = new DevExpress.XtraEditors.TextEdit();
            txtResponsavel = new DevExpress.XtraEditors.TextEdit();
            txtCliente = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)tpOpcoesImportar).BeginInit();
            tpOpcoesImportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chkImportarEstoque.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarContasAReceber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarContasAPagar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarFornecedores.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarClientes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarProdutosOpcoes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rgRegime.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tpImplantacao).BeginInit();
            tpImplantacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBackupOriginal.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFormularioOriginal.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSistemaERP.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtResponsavel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCliente.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCliente.Appearance.Options.UseFont = true;
            tpImplantacao.SetColumn(lblCliente, 0);
            lblCliente.Location = new System.Drawing.Point(13, 14);
            lblCliente.Name = "lblCliente";
            tpImplantacao.SetRow(lblCliente, 0);
            lblCliente.Size = new System.Drawing.Size(51, 16);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // lblResponsavel
            // 
            lblResponsavel.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblResponsavel.Appearance.Options.UseFont = true;
            tpImplantacao.SetColumn(lblResponsavel, 0);
            lblResponsavel.Location = new System.Drawing.Point(13, 40);
            lblResponsavel.Name = "lblResponsavel";
            tpImplantacao.SetRow(lblResponsavel, 1);
            lblResponsavel.Size = new System.Drawing.Size(92, 16);
            lblResponsavel.TabIndex = 3;
            lblResponsavel.Text = "Responsável";
            // 
            // tpOpcoesImportar
            // 
            tpOpcoesImportar.Appearance.BackColor = System.Drawing.Color.White;
            tpOpcoesImportar.Appearance.Options.UseBackColor = true;
            tpOpcoesImportar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            tpOpcoesImportar.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33.16F) });
            tpOpcoesImportar.Controls.Add(lblImportarClientes);
            tpOpcoesImportar.Controls.Add(chkImportarEstoque);
            tpOpcoesImportar.Controls.Add(cbImportarContasAReceber);
            tpOpcoesImportar.Controls.Add(cbImportarContasAPagar);
            tpOpcoesImportar.Controls.Add(cbImportarFornecedores);
            tpOpcoesImportar.Controls.Add(cbImportarClientes);
            tpOpcoesImportar.Controls.Add(cbImportarProdutosOpcoes);
            tpOpcoesImportar.Controls.Add(labelControl6);
            tpOpcoesImportar.Controls.Add(labelControl5);
            tpOpcoesImportar.Controls.Add(labelControl4);
            tpOpcoesImportar.Controls.Add(labelControl3);
            tpOpcoesImportar.Controls.Add(labelControl1);
            tpOpcoesImportar.Location = new System.Drawing.Point(16, 310);
            tpOpcoesImportar.Name = "tpOpcoesImportar";
            tpOpcoesImportar.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F) });
            tpOpcoesImportar.Size = new System.Drawing.Size(506, 169);
            tpOpcoesImportar.TabIndex = 8;
            tpOpcoesImportar.UseSkinIndents = true;
            // 
            // lblImportarClientes
            // 
            lblImportarClientes.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblImportarClientes.Appearance.Options.UseFont = true;
            lblImportarClientes.Location = new System.Drawing.Point(13, 15);
            lblImportarClientes.Name = "lblImportarClientes";
            lblImportarClientes.Size = new System.Drawing.Size(100, 13);
            lblImportarClientes.TabIndex = 12;
            lblImportarClientes.Text = "Importar Clientes";
            // 
            // chkImportarEstoque
            // 
            chkImportarEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            chkImportarEstoque.Location = new System.Drawing.Point(230, 132);
            chkImportarEstoque.Name = "chkImportarEstoque";
            chkImportarEstoque.Properties.Appearance.Options.UseTextOptions = true;
            chkImportarEstoque.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            chkImportarEstoque.Properties.AutoHeight = false;
            chkImportarEstoque.Properties.Caption = "";
            chkImportarEstoque.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            chkImportarEstoque.Size = new System.Drawing.Size(263, 20);
            chkImportarEstoque.TabIndex = 11;
            // 
            // cbImportarContasAReceber
            // 
            tpOpcoesImportar.SetColumn(cbImportarContasAReceber, 1);
            cbImportarContasAReceber.Location = new System.Drawing.Point(230, 84);
            cbImportarContasAReceber.Name = "cbImportarContasAReceber";
            cbImportarContasAReceber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbImportarContasAReceber.Properties.Items.AddRange(new object[] { "Nenhuma", "Somente a Receber", "Contas Recebidas e Contas a Receber" });
            tpOpcoesImportar.SetRow(cbImportarContasAReceber, 3);
            cbImportarContasAReceber.Size = new System.Drawing.Size(263, 20);
            cbImportarContasAReceber.TabIndex = 10;
            // 
            // cbImportarContasAPagar
            // 
            tpOpcoesImportar.SetColumn(cbImportarContasAPagar, 1);
            cbImportarContasAPagar.Location = new System.Drawing.Point(230, 60);
            cbImportarContasAPagar.Name = "cbImportarContasAPagar";
            cbImportarContasAPagar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbImportarContasAPagar.Properties.Items.AddRange(new object[] { "Nenhuma", "Somente a Pagar", "Contas Pagas e Contas a Pagar" });
            tpOpcoesImportar.SetRow(cbImportarContasAPagar, 2);
            cbImportarContasAPagar.Size = new System.Drawing.Size(263, 20);
            cbImportarContasAPagar.TabIndex = 9;
            // 
            // cbImportarFornecedores
            // 
            tpOpcoesImportar.SetColumn(cbImportarFornecedores, 1);
            cbImportarFornecedores.Location = new System.Drawing.Point(230, 36);
            cbImportarFornecedores.Name = "cbImportarFornecedores";
            cbImportarFornecedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbImportarFornecedores.Properties.Items.AddRange(new object[] { "Não", "Sim", "Sim, Manter Códigos Originais" });
            tpOpcoesImportar.SetRow(cbImportarFornecedores, 1);
            cbImportarFornecedores.Size = new System.Drawing.Size(263, 20);
            cbImportarFornecedores.TabIndex = 8;
            // 
            // cbImportarClientes
            // 
            tpOpcoesImportar.SetColumn(cbImportarClientes, 1);
            cbImportarClientes.Location = new System.Drawing.Point(230, 12);
            cbImportarClientes.Name = "cbImportarClientes";
            cbImportarClientes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbImportarClientes.Properties.Items.AddRange(new object[] { "Não", "Sim", "Sim, Manter Códigos Originais" });
            tpOpcoesImportar.SetRow(cbImportarClientes, 0);
            cbImportarClientes.Size = new System.Drawing.Size(263, 20);
            cbImportarClientes.TabIndex = 7;
            // 
            // cbImportarProdutosOpcoes
            // 
            tpOpcoesImportar.SetColumn(cbImportarProdutosOpcoes, 1);
            cbImportarProdutosOpcoes.EditValue = "";
            cbImportarProdutosOpcoes.Location = new System.Drawing.Point(230, 108);
            cbImportarProdutosOpcoes.Name = "cbImportarProdutosOpcoes";
            cbImportarProdutosOpcoes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbImportarProdutosOpcoes.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] { new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Sim"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Não", System.Windows.Forms.CheckState.Checked), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Seções"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Grupos"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Subgrupos"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Grades"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Lotes") });
            tpOpcoesImportar.SetRow(cbImportarProdutosOpcoes, 4);
            cbImportarProdutosOpcoes.Size = new System.Drawing.Size(263, 20);
            cbImportarProdutosOpcoes.TabIndex = 6;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            labelControl6.Appearance.Options.UseFont = true;
            tpOpcoesImportar.SetColumn(labelControl6, 0);
            labelControl6.Location = new System.Drawing.Point(13, 137);
            labelControl6.Name = "labelControl6";
            tpOpcoesImportar.SetRow(labelControl6, 5);
            labelControl6.Size = new System.Drawing.Size(100, 13);
            labelControl6.TabIndex = 5;
            labelControl6.Text = "Importar Estoque";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            tpOpcoesImportar.SetColumn(labelControl5, 0);
            labelControl5.Location = new System.Drawing.Point(13, 111);
            labelControl5.Name = "labelControl5";
            tpOpcoesImportar.SetRow(labelControl5, 4);
            labelControl5.Size = new System.Drawing.Size(106, 13);
            labelControl5.TabIndex = 4;
            labelControl5.Text = "Importar Produtos";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            tpOpcoesImportar.SetColumn(labelControl4, 0);
            labelControl4.Location = new System.Drawing.Point(13, 87);
            labelControl4.Name = "labelControl4";
            tpOpcoesImportar.SetRow(labelControl4, 3);
            labelControl4.Size = new System.Drawing.Size(154, 13);
            labelControl4.TabIndex = 3;
            labelControl4.Text = "Importar Contas a Receber";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            tpOpcoesImportar.SetColumn(labelControl3, 0);
            labelControl3.Location = new System.Drawing.Point(13, 63);
            labelControl3.Name = "labelControl3";
            tpOpcoesImportar.SetRow(labelControl3, 2);
            labelControl3.Size = new System.Drawing.Size(140, 13);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "Importar Contas a Pagar";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            tpOpcoesImportar.SetColumn(labelControl1, 0);
            labelControl1.Location = new System.Drawing.Point(13, 39);
            labelControl1.Name = "labelControl1";
            tpOpcoesImportar.SetRow(labelControl1, 1);
            labelControl1.Size = new System.Drawing.Size(132, 13);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Importar Fornecedores";
            // 
            // lblSistemaERP
            // 
            lblSistemaERP.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSistemaERP.Appearance.Options.UseFont = true;
            tpImplantacao.SetColumn(lblSistemaERP, 0);
            lblSistemaERP.Location = new System.Drawing.Point(13, 66);
            lblSistemaERP.Name = "lblSistemaERP";
            tpImplantacao.SetRow(lblSistemaERP, 2);
            lblSistemaERP.Size = new System.Drawing.Size(90, 16);
            lblSistemaERP.TabIndex = 10;
            lblSistemaERP.Text = "Sistema ERP";
            // 
            // lblFormularioOriginal
            // 
            lblFormularioOriginal.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFormularioOriginal.Appearance.Options.UseFont = true;
            tpImplantacao.SetColumn(lblFormularioOriginal, 0);
            lblFormularioOriginal.Location = new System.Drawing.Point(13, 92);
            lblFormularioOriginal.Name = "lblFormularioOriginal";
            tpImplantacao.SetRow(lblFormularioOriginal, 3);
            lblFormularioOriginal.Size = new System.Drawing.Size(139, 16);
            lblFormularioOriginal.TabIndex = 12;
            lblFormularioOriginal.Text = "Formulário Original";
            // 
            // lblBackupOriginal
            // 
            lblBackupOriginal.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBackupOriginal.Appearance.Options.UseFont = true;
            tpImplantacao.SetColumn(lblBackupOriginal, 0);
            lblBackupOriginal.Location = new System.Drawing.Point(13, 118);
            lblBackupOriginal.Name = "lblBackupOriginal";
            tpImplantacao.SetRow(lblBackupOriginal, 4);
            lblBackupOriginal.Size = new System.Drawing.Size(113, 16);
            lblBackupOriginal.TabIndex = 13;
            lblBackupOriginal.Text = "Backup Original";
            // 
            // rgRegime
            // 
            rgRegime.Location = new System.Drawing.Point(16, 485);
            rgRegime.Name = "rgRegime";
            rgRegime.Properties.Appearance.Options.UseTextOptions = true;
            rgRegime.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            rgRegime.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            rgRegime.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] { new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Simples Nacional"), new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Lucro Real"), new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Lucro Presumido") });
            rgRegime.Size = new System.Drawing.Size(506, 34);
            rgRegime.TabIndex = 20;
            // 
            // tpImplantacao
            // 
            tpImplantacao.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            tpImplantacao.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.12F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 39.88F) });
            tpImplantacao.Controls.Add(txtBackupOriginal);
            tpImplantacao.Controls.Add(txtFormularioOriginal);
            tpImplantacao.Controls.Add(txtSistemaERP);
            tpImplantacao.Controls.Add(txtResponsavel);
            tpImplantacao.Controls.Add(txtCliente);
            tpImplantacao.Controls.Add(lblCliente);
            tpImplantacao.Controls.Add(lblResponsavel);
            tpImplantacao.Controls.Add(lblSistemaERP);
            tpImplantacao.Controls.Add(lblFormularioOriginal);
            tpImplantacao.Controls.Add(lblBackupOriginal);
            tpImplantacao.Location = new System.Drawing.Point(16, 24);
            tpImplantacao.Name = "tpImplantacao";
            tpImplantacao.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
            tpImplantacao.Size = new System.Drawing.Size(506, 152);
            tpImplantacao.TabIndex = 21;
            tpImplantacao.UseSkinIndents = true;
            // 
            // txtBackupOriginal
            // 
            tpImplantacao.SetColumn(txtBackupOriginal, 1);
            txtBackupOriginal.Location = new System.Drawing.Point(175, 117);
            txtBackupOriginal.Name = "txtBackupOriginal";
            txtBackupOriginal.Properties.SingleClick = false;
            txtBackupOriginal.Properties.StartLinkOnClickingEmptySpace = false;
            txtBackupOriginal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            tpImplantacao.SetRow(txtBackupOriginal, 4);
            txtBackupOriginal.Size = new System.Drawing.Size(318, 20);
            txtBackupOriginal.TabIndex = 23;
            // 
            // txtFormularioOriginal
            // 
            tpImplantacao.SetColumn(txtFormularioOriginal, 1);
            txtFormularioOriginal.Location = new System.Drawing.Point(175, 91);
            txtFormularioOriginal.Name = "txtFormularioOriginal";
            txtFormularioOriginal.Properties.SingleClick = false;
            txtFormularioOriginal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            tpImplantacao.SetRow(txtFormularioOriginal, 3);
            txtFormularioOriginal.Size = new System.Drawing.Size(318, 20);
            txtFormularioOriginal.TabIndex = 22;
            // 
            // txtSistemaERP
            // 
            tpImplantacao.SetColumn(txtSistemaERP, 1);
            txtSistemaERP.Location = new System.Drawing.Point(175, 65);
            txtSistemaERP.Name = "txtSistemaERP";
            tpImplantacao.SetRow(txtSistemaERP, 2);
            txtSistemaERP.Size = new System.Drawing.Size(318, 20);
            txtSistemaERP.TabIndex = 16;
            // 
            // txtResponsavel
            // 
            tpImplantacao.SetColumn(txtResponsavel, 1);
            txtResponsavel.Location = new System.Drawing.Point(175, 39);
            txtResponsavel.Name = "txtResponsavel";
            tpImplantacao.SetRow(txtResponsavel, 1);
            txtResponsavel.Size = new System.Drawing.Size(318, 20);
            txtResponsavel.TabIndex = 15;
            // 
            // txtCliente
            // 
            tpImplantacao.SetColumn(txtCliente, 1);
            txtCliente.Location = new System.Drawing.Point(175, 13);
            txtCliente.Name = "txtCliente";
            tpImplantacao.SetRow(txtCliente, 0);
            txtCliente.Size = new System.Drawing.Size(318, 20);
            txtCliente.TabIndex = 14;
            // 
            // UCImplantacao
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tpImplantacao);
            Controls.Add(rgRegime);
            Controls.Add(tpOpcoesImportar);
            Name = "UCImplantacao";
            Size = new System.Drawing.Size(542, 541);
            Load += UCImplantacao_Load;
            Leave += UCImplantacao_Leave;
            ((System.ComponentModel.ISupportInitialize)tpOpcoesImportar).EndInit();
            tpOpcoesImportar.ResumeLayout(false);
            tpOpcoesImportar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chkImportarEstoque.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarContasAReceber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarContasAPagar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarFornecedores.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarClientes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarProdutosOpcoes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)rgRegime.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tpImplantacao).EndInit();
            tpImplantacao.ResumeLayout(false);
            tpImplantacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBackupOriginal.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFormularioOriginal.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSistemaERP.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtResponsavel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCliente.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCliente;
        private DevExpress.XtraEditors.LabelControl lblResponsavel;
        private DevExpress.Utils.Layout.TablePanel tpOpcoesImportar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblImportarClientes;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbImportarProdutosOpcoes;
        private DevExpress.XtraEditors.ComboBoxEdit cbImportarClientes;
        private DevExpress.XtraEditors.ComboBoxEdit cbImportarContasAReceber;
        private DevExpress.XtraEditors.ComboBoxEdit cbImportarContasAPagar;
        private DevExpress.XtraEditors.ComboBoxEdit cbImportarFornecedores;
        private DevExpress.XtraEditors.CheckEdit chkImportarEstoque;
        private DevExpress.XtraEditors.LabelControl lblSistemaERP;
        private DevExpress.XtraEditors.LabelControl lblFormularioOriginal;
        private DevExpress.XtraEditors.LabelControl lblBackupOriginal;
        private DevExpress.XtraEditors.RadioGroup rgRegime;
        private DevExpress.Utils.Layout.TablePanel tpImplantacao;
        private DevExpress.XtraEditors.TextEdit txtSistemaERP;
        private DevExpress.XtraEditors.TextEdit txtResponsavel;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.HyperLinkEdit txtBackupOriginal;
        private DevExpress.XtraEditors.HyperLinkEdit txtFormularioOriginal;
    }
}
