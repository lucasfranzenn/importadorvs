namespace Importador.UserControls.Componentes
{
    partial class Observacao
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
            lblTela = new DevExpress.XtraEditors.LabelControl();
            txtObservacao = new DevExpress.XtraEditors.MemoEdit();
            imgVoltar = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)txtObservacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgVoltar).BeginInit();
            SuspendLayout();
            // 
            // lblTela
            // 
            lblTela.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblTela.Appearance.Options.UseFont = true;
            lblTela.Location = new System.Drawing.Point(12, 7);
            lblTela.Name = "lblTela";
            lblTela.Size = new System.Drawing.Size(0, 13);
            lblTela.TabIndex = 0;
            // 
            // txtObservacao
            // 
            txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtObservacao.Location = new System.Drawing.Point(12, 26);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new System.Drawing.Size(284, 103);
            txtObservacao.TabIndex = 1;
            // 
            // imgVoltar
            // 
            imgVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            imgVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            imgVoltar.Location = new System.Drawing.Point(276, 4);
            imgVoltar.Name = "imgVoltar";
            imgVoltar.Size = new System.Drawing.Size(20, 18);
            imgVoltar.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            imgVoltar.SvgImage = Properties.Resources.previous;
            imgVoltar.TabIndex = 2;
            imgVoltar.ToolTip = "Voltar para tela anterior";
            imgVoltar.Click += imgVoltar_Click;
            // 
            // Observacao
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(imgVoltar);
            Controls.Add(txtObservacao);
            Controls.Add(lblTela);
            Name = "Observacao";
            Size = new System.Drawing.Size(310, 143);
            Load += Observacao_Load;
            Leave += Observacao_Leave;
            ((System.ComponentModel.ISupportInitialize)txtObservacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgVoltar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTela;
        private DevExpress.XtraEditors.MemoEdit txtObservacao;
        private DevExpress.XtraEditors.SvgImageBox imgVoltar;
    }
}
