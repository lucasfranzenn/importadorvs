namespace Importador.UserControls.Importacao
{
    partial class UCGenerico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGenerico));
            cbTabelas = new DevExpress.XtraEditors.ComboBoxEdit();
            lblSelecionarTabela = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbTabelas.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblSqlImportacao
            // 
            lblSqlImportacao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblSqlImportacao.Appearance.Options.UseFont = true;
            // 
            // txtSqlImportacao
            // 
            // 
            // btnImportar
            // 
            btnImportar.Click += btnImportar_Click_1;
            // 
            // pbImportacao
            // 
            pbImportacao.Properties.DisplayFormat.FormatString = "Nenhum registro importado";
            pbImportacao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // btnResetarSql
            // 
            btnResetarSql.Enabled = false;
            btnResetarSql.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnResetarSql.ImageOptions.Image");
            btnResetarSql.Location = new System.Drawing.Point(309, 519);
            btnResetarSql.Visible = false;
            // 
            // MyC
            // 
            MyC.Tabela = Classes.Constantes.Enums.TabelaMyCommerce.generico;
            // 
            // btnObservacao
            // 
            btnObservacao.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnObservacao.ImageOptions.Image");
            btnObservacao.Location = new System.Drawing.Point(512, 9);
            btnObservacao.Click += btnObservacao_Click_1;
            // 
            // cbTabelas
            // 
            cbTabelas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbTabelas.Location = new System.Drawing.Point(385, 11);
            cbTabelas.Name = "cbTabelas";
            cbTabelas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus) });
            cbTabelas.Size = new System.Drawing.Size(121, 20);
            cbTabelas.TabIndex = 17;
            cbTabelas.SelectedIndexChanged += cbTabelas_SelectedIndexChanged;
            cbTabelas.ButtonClick += cbTabelas_ButtonClick;
            // 
            // lblSelecionarTabela
            // 
            lblSelecionarTabela.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSelecionarTabela.Location = new System.Drawing.Point(217, 14);
            lblSelecionarTabela.Name = "lblSelecionarTabela";
            lblSelecionarTabela.Size = new System.Drawing.Size(162, 13);
            lblSelecionarTabela.TabIndex = 18;
            lblSelecionarTabela.Text = "Cadastre ou selecione uma tabela";
            // 
            // UCGenerico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblSelecionarTabela);
            Controls.Add(cbTabelas);
            Name = "UCGenerico";
            Load += UCGenerico_Load;
            Controls.SetChildIndex(btnObservacao, 0);
            Controls.SetChildIndex(btnResetarSql, 0);
            Controls.SetChildIndex(txtSqlImportacao, 0);
            Controls.SetChildIndex(lblSqlImportacao, 0);
            Controls.SetChildIndex(gcParametros, 0);
            Controls.SetChildIndex(btnImportar, 0);
            Controls.SetChildIndex(lblHorarioInicioImportacao, 0);
            Controls.SetChildIndex(lblHorarioFimImportacao, 0);
            Controls.SetChildIndex(pbImportacao, 0);
            Controls.SetChildIndex(cbTabelas, 0);
            Controls.SetChildIndex(lblSelecionarTabela, 0);
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbTabelas.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbTabelas;
        private DevExpress.XtraEditors.LabelControl lblSelecionarTabela;
    }
}
