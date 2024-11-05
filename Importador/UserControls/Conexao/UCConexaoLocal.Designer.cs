namespace Importador.UserControls.Conexao
{
    partial class UCConexaoLocal
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
            txtCaminhoBanco = new DevExpress.XtraEditors.TextEdit();
            lblBanco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtCaminhoBanco.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtCaminhoBanco
            // 
            txtCaminhoBanco.Location = new System.Drawing.Point(16, 52);
            txtCaminhoBanco.Name = "txtCaminhoBanco";
            txtCaminhoBanco.Size = new System.Drawing.Size(513, 20);
            txtCaminhoBanco.TabIndex = 13;
            txtCaminhoBanco.KeyDown += txtCaminhoBanco_KeyDown;
            // 
            // lblBanco
            // 
            lblBanco.AutoSize = true;
            lblBanco.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblBanco.Location = new System.Drawing.Point(16, 32);
            lblBanco.Name = "lblBanco";
            lblBanco.Size = new System.Drawing.Size(320, 17);
            lblBanco.TabIndex = 12;
            lblBanco.Text = "Caminho do Banco Local do Importador";
            // 
            // UCConexaoLocal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(txtCaminhoBanco);
            Controls.Add(lblBanco);
            Name = "UCConexaoLocal";
            Load += UCConexaoLocal_Load;
            Leave += UCConexaoLocal_Leave;
            ((System.ComponentModel.ISupportInitialize)txtCaminhoBanco.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DevExpress.XtraEditors.TextEdit txtCaminhoBanco;
        public System.Windows.Forms.Label lblBanco;
    }
}
