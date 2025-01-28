namespace Importador.UserControls.Importacao
{
    partial class UCCentralizador
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
            btnCentralizarClientes = new DevExpress.XtraEditors.SimpleButton();
            pbImportacao = new DevExpress.XtraEditors.ProgressBarControl();
            btnCentralizarProdutos = new DevExpress.XtraEditors.SimpleButton();
            lblConfiguracoesCentralizador = new DevExpress.XtraEditors.LabelControl();
            tpImplantacao = new DevExpress.Utils.Layout.TablePanel();
            txtTaxaMinima = new DevExpress.XtraEditors.TextEdit();
            lblTaxaMinima = new DevExpress.XtraEditors.LabelControl();
            btnCentralizarSecoes = new DevExpress.XtraEditors.SimpleButton();
            gcOpcoesCentralizar = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tpImplantacao).BeginInit();
            tpImplantacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTaxaMinima.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcOpcoesCentralizar).BeginInit();
            gcOpcoesCentralizar.SuspendLayout();
            SuspendLayout();
            // 
            // btnCentralizarClientes
            // 
            btnCentralizarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCentralizarClientes.Location = new System.Drawing.Point(8, 26);
            btnCentralizarClientes.Name = "btnCentralizarClientes";
            btnCentralizarClientes.Size = new System.Drawing.Size(113, 33);
            btnCentralizarClientes.TabIndex = 0;
            btnCentralizarClientes.Text = "&Clientes";
            btnCentralizarClientes.ToolTip = "Excluirá todo registro com cgc duplicado";
            btnCentralizarClientes.Click += btnCentralizarClientes_Click;
            // 
            // pbImportacao
            // 
            pbImportacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pbImportacao.Location = new System.Drawing.Point(20, 491);
            pbImportacao.Name = "pbImportacao";
            pbImportacao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            pbImportacao.Properties.DisplayFormat.FormatString = "Nenhum registro importado";
            pbImportacao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            pbImportacao.Properties.PercentView = false;
            pbImportacao.Properties.ShowTitle = true;
            pbImportacao.Properties.Step = 1;
            pbImportacao.Size = new System.Drawing.Size(514, 26);
            pbImportacao.TabIndex = 16;
            // 
            // btnCentralizarProdutos
            // 
            btnCentralizarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCentralizarProdutos.Location = new System.Drawing.Point(127, 26);
            btnCentralizarProdutos.Name = "btnCentralizarProdutos";
            btnCentralizarProdutos.Size = new System.Drawing.Size(113, 33);
            btnCentralizarProdutos.TabIndex = 17;
            btnCentralizarProdutos.Text = "&Produtos";
            btnCentralizarProdutos.ToolTip = "Unifica com base no nome igual ou codigo de barras";
            btnCentralizarProdutos.Click += btnCentralizarProdutos_Click;
            // 
            // lblConfiguracoesCentralizador
            // 
            lblConfiguracoesCentralizador.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            lblConfiguracoesCentralizador.Appearance.Options.UseFont = true;
            lblConfiguracoesCentralizador.Location = new System.Drawing.Point(25, 9);
            lblConfiguracoesCentralizador.Name = "lblConfiguracoesCentralizador";
            lblConfiguracoesCentralizador.Size = new System.Drawing.Size(256, 19);
            lblConfiguracoesCentralizador.TabIndex = 28;
            lblConfiguracoesCentralizador.Text = "Configurações do Centralizador";
            // 
            // tpImplantacao
            // 
            tpImplantacao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tpImplantacao.AutoSize = true;
            tpImplantacao.AutoTabOrder = false;
            tpImplantacao.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            tpImplantacao.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.12F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 39.88F) });
            tpImplantacao.Controls.Add(txtTaxaMinima);
            tpImplantacao.Controls.Add(lblTaxaMinima);
            tpImplantacao.Location = new System.Drawing.Point(20, 19);
            tpImplantacao.Name = "tpImplantacao";
            tpImplantacao.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
            tpImplantacao.Size = new System.Drawing.Size(506, 51);
            tpImplantacao.TabIndex = 27;
            tpImplantacao.UseSkinIndents = true;
            // 
            // txtTaxaMinima
            // 
            tpImplantacao.SetColumn(txtTaxaMinima, 1);
            txtTaxaMinima.EnterMoveNextControl = true;
            txtTaxaMinima.Location = new System.Drawing.Point(175, 15);
            txtTaxaMinima.Name = "txtTaxaMinima";
            txtTaxaMinima.Properties.NullText = "60";
            txtTaxaMinima.Properties.NullValuePrompt = "60";
            tpImplantacao.SetRow(txtTaxaMinima, 0);
            txtTaxaMinima.Size = new System.Drawing.Size(318, 20);
            txtTaxaMinima.TabIndex = 1;
            // 
            // lblTaxaMinima
            // 
            lblTaxaMinima.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblTaxaMinima.Appearance.Options.UseFont = true;
            tpImplantacao.SetColumn(lblTaxaMinima, 0);
            lblTaxaMinima.Location = new System.Drawing.Point(13, 18);
            lblTaxaMinima.Name = "lblTaxaMinima";
            tpImplantacao.SetRow(lblTaxaMinima, 0);
            lblTaxaMinima.Size = new System.Drawing.Size(72, 13);
            lblTaxaMinima.TabIndex = 24;
            lblTaxaMinima.Text = "Taxa Minima";
            // 
            // btnCentralizarSecoes
            // 
            btnCentralizarSecoes.Appearance.Options.UseTextOptions = true;
            btnCentralizarSecoes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            btnCentralizarSecoes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCentralizarSecoes.Location = new System.Drawing.Point(246, 26);
            btnCentralizarSecoes.Name = "btnCentralizarSecoes";
            btnCentralizarSecoes.Size = new System.Drawing.Size(250, 33);
            btnCentralizarSecoes.TabIndex = 29;
            btnCentralizarSecoes.Text = "&Seções/Grupos/Subgrupos/Fabricantes";
            btnCentralizarSecoes.Click += btnCentralizarSecoes_Click;
            // 
            // gcOpcoesCentralizar
            // 
            gcOpcoesCentralizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gcOpcoesCentralizar.Controls.Add(btnCentralizarClientes);
            gcOpcoesCentralizar.Controls.Add(btnCentralizarSecoes);
            gcOpcoesCentralizar.Controls.Add(btnCentralizarProdutos);
            gcOpcoesCentralizar.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            gcOpcoesCentralizar.Location = new System.Drawing.Point(20, 412);
            gcOpcoesCentralizar.Name = "gcOpcoesCentralizar";
            gcOpcoesCentralizar.Size = new System.Drawing.Size(514, 73);
            gcOpcoesCentralizar.TabIndex = 30;
            gcOpcoesCentralizar.Text = "Opções para centralizar";
            // 
            // UCCentralizador
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gcOpcoesCentralizar);
            Controls.Add(lblConfiguracoesCentralizador);
            Controls.Add(tpImplantacao);
            Controls.Add(pbImportacao);
            Name = "UCCentralizador";
            Load += UCCentralizador_Load;
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tpImplantacao).EndInit();
            tpImplantacao.ResumeLayout(false);
            tpImplantacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTaxaMinima.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcOpcoesCentralizar).EndInit();
            gcOpcoesCentralizar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCentralizarClientes;
        public DevExpress.XtraEditors.ProgressBarControl pbImportacao;
        private DevExpress.XtraEditors.SimpleButton btnCentralizarProdutos;
        private DevExpress.XtraEditors.LabelControl lblConfiguracoesCentralizador;
        private DevExpress.Utils.Layout.TablePanel tpImplantacao;
        private DevExpress.XtraEditors.TextEdit txtTaxaMinima;
        private DevExpress.XtraEditors.LabelControl lblTaxaMinima;
        private DevExpress.XtraEditors.SimpleButton btnCentralizarSecoes;
        private DevExpress.XtraEditors.GroupControl gcOpcoesCentralizar;
    }
}
