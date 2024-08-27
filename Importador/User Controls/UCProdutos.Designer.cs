namespace Importador.User_Controls
{
    partial class UCProdutos
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
            lblSqlImportacao = new DevExpress.XtraEditors.LabelControl();
            txtSqlImportacao = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblSqlImportacao
            // 
            lblSqlImportacao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblSqlImportacao.Appearance.Options.UseFont = true;
            lblSqlImportacao.Location = new System.Drawing.Point(20, 9);
            lblSqlImportacao.Name = "lblSqlImportacao";
            lblSqlImportacao.Size = new System.Drawing.Size(91, 13);
            lblSqlImportacao.TabIndex = 4;
            lblSqlImportacao.Text = "SQL Importação";
            // 
            // txtSqlImportacao
            // 
            txtSqlImportacao.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            txtSqlImportacao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSqlImportacao.Location = new System.Drawing.Point(20, 28);
            txtSqlImportacao.Name = "txtSqlImportacao";
            txtSqlImportacao.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            txtSqlImportacao.Size = new System.Drawing.Size(473, 169);
            txtSqlImportacao.TabIndex = 3;
            // 
            // UCProdutos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblSqlImportacao);
            Controls.Add(txtSqlImportacao);
            Name = "UCProdutos";
            Size = new System.Drawing.Size(542, 541);
            Load += UCProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSqlImportacao;
        private DevExpress.XtraEditors.MemoEdit txtSqlImportacao;
    }
}
