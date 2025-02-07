namespace Importador.UserControls.Utilitarios
{
    partial class UCScriptSQL
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
            components = new System.ComponentModel.Container();
            lblScriptSQL = new DevExpress.XtraEditors.LabelControl();
            txtScriptSQL = new DevExpress.XtraEditors.MemoEdit();
            btnExecutarTextoSelecionado = new DevExpress.XtraEditors.SimpleButton();
            txtLog = new DevExpress.XtraEditors.MemoEdit();
            lblLog = new DevExpress.XtraEditors.LabelControl();
            cbConexao = new DevExpress.XtraEditors.ComboBoxEdit();
            tcDataSet = new DevExpress.XtraTab.XtraTabControl();
            btnObservacao = new DevExpress.XtraEditors.SimpleButton();
            MyC = new Componentes.TabelaMyCommerce(components);
            ((System.ComponentModel.ISupportInitialize)txtScriptSQL.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLog.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbConexao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tcDataSet).BeginInit();
            SuspendLayout();
            // 
            // lblScriptSQL
            // 
            lblScriptSQL.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblScriptSQL.Appearance.Options.UseFont = true;
            lblScriptSQL.Location = new System.Drawing.Point(21, 14);
            lblScriptSQL.Name = "lblScriptSQL";
            lblScriptSQL.Size = new System.Drawing.Size(57, 13);
            lblScriptSQL.TabIndex = 6;
            lblScriptSQL.Text = "Script SQL";
            // 
            // txtScriptSQL
            // 
            txtScriptSQL.AllowDrop = true;
            txtScriptSQL.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            txtScriptSQL.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtScriptSQL.Location = new System.Drawing.Point(21, 33);
            txtScriptSQL.Name = "txtScriptSQL";
            txtScriptSQL.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            txtScriptSQL.Size = new System.Drawing.Size(514, 286);
            txtScriptSQL.TabIndex = 5;
            txtScriptSQL.KeyDown += txtScriptSQL_KeyDown;
            // 
            // btnExecutarTextoSelecionado
            // 
            btnExecutarTextoSelecionado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnExecutarTextoSelecionado.ImageOptions.Image = Properties.Resources.media_16x16;
            btnExecutarTextoSelecionado.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnExecutarTextoSelecionado.Location = new System.Drawing.Point(515, 11);
            btnExecutarTextoSelecionado.Name = "btnExecutarTextoSelecionado";
            btnExecutarTextoSelecionado.Size = new System.Drawing.Size(20, 20);
            btnExecutarTextoSelecionado.TabIndex = 7;
            btnExecutarTextoSelecionado.ToolTip = "F9 - Irá executar o texto selecionado";
            btnExecutarTextoSelecionado.Click += btnExecutarTextoSelecionado_Click;
            // 
            // txtLog
            // 
            txtLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLog.Location = new System.Drawing.Point(21, 343);
            txtLog.Name = "txtLog";
            txtLog.Properties.ReadOnly = true;
            txtLog.Size = new System.Drawing.Size(514, 59);
            txtLog.TabIndex = 8;
            // 
            // lblLog
            // 
            lblLog.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblLog.Appearance.Options.UseFont = true;
            lblLog.Location = new System.Drawing.Point(21, 325);
            lblLog.Name = "lblLog";
            lblLog.Size = new System.Drawing.Size(94, 13);
            lblLog.TabIndex = 9;
            lblLog.Text = "Log de execução";
            // 
            // cbConexao
            // 
            cbConexao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbConexao.EditValue = "MyCommerce";
            cbConexao.Location = new System.Drawing.Point(259, 11);
            cbConexao.Name = "cbConexao";
            cbConexao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbConexao.Properties.Items.AddRange(new object[] { "MyCommerce", "Importação", "Banco Local (Importador)" });
            cbConexao.Properties.Name = "cbConexao";
            cbConexao.Size = new System.Drawing.Size(224, 20);
            cbConexao.TabIndex = 24;
            cbConexao.SelectedValueChanged += cbConexao_SelectedValueChanged;
            // 
            // tcDataSet
            // 
            tcDataSet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tcDataSet.Location = new System.Drawing.Point(21, 408);
            tcDataSet.Name = "tcDataSet";
            tcDataSet.Size = new System.Drawing.Size(514, 128);
            tcDataSet.TabIndex = 26;
            // 
            // btnObservacao
            // 
            btnObservacao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnObservacao.Cursor = System.Windows.Forms.Cursors.Hand;
            btnObservacao.ImageOptions.Image = Properties.Resources.edittask_16x16;
            btnObservacao.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnObservacao.Location = new System.Drawing.Point(489, 11);
            btnObservacao.Name = "btnObservacao";
            btnObservacao.Size = new System.Drawing.Size(20, 20);
            btnObservacao.TabIndex = 27;
            btnObservacao.Text = "&";
            btnObservacao.ToolTip = "Anotações referentes a importação deste módulo";
            btnObservacao.Click += btnObservacao_Click;
            // 
            // MyC
            // 
            MyC.Tabela = Classes.Constantes.Enums.TabelaMyCommerce.scriptsql;
            // 
            // UCScriptSQL
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnObservacao);
            Controls.Add(tcDataSet);
            Controls.Add(cbConexao);
            Controls.Add(lblLog);
            Controls.Add(txtLog);
            Controls.Add(btnExecutarTextoSelecionado);
            Controls.Add(lblScriptSQL);
            Controls.Add(txtScriptSQL);
            Name = "UCScriptSQL";
            Load += UCScriptSQL_Load;
            ((System.ComponentModel.ISupportInitialize)txtScriptSQL.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLog.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbConexao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tcDataSet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected DevExpress.XtraEditors.LabelControl lblScriptSQL;
        protected DevExpress.XtraEditors.MemoEdit txtScriptSQL;
        private DevExpress.XtraEditors.SimpleButton btnExecutarTextoSelecionado;
        private DevExpress.XtraEditors.MemoEdit txtLog;
        protected DevExpress.XtraEditors.LabelControl lblLog;
        private DevExpress.XtraEditors.ComboBoxEdit cbConexao;
        private DevExpress.XtraTab.XtraTabControl tcDataSet;
        public DevExpress.XtraEditors.SimpleButton btnObservacao;
        private Componentes.TabelaMyCommerce MyC;
    }
}
