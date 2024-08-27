namespace Importador.User_Controls
{
    partial class UCConexaoMyCommerce
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
            lblHost = new System.Windows.Forms.Label();
            txtHost = new DevExpress.XtraEditors.TextEdit();
            txtPorta = new DevExpress.XtraEditors.TextEdit();
            lblPorta = new System.Windows.Forms.Label();
            txtUsuario = new DevExpress.XtraEditors.TextEdit();
            lblUsuario = new System.Windows.Forms.Label();
            txtSenha = new DevExpress.XtraEditors.TextEdit();
            lblSenha = new System.Windows.Forms.Label();
            txtBancoDeDados = new DevExpress.XtraEditors.TextEdit();
            lblBancoDeDados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtHost.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPorta.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBancoDeDados.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblHost.Location = new System.Drawing.Point(12, 32);
            lblHost.Name = "lblHost";
            lblHost.Size = new System.Drawing.Size(43, 17);
            lblHost.TabIndex = 0;
            lblHost.Text = "Host";
            // 
            // txtHost
            // 
            txtHost.Location = new System.Drawing.Point(12, 52);
            txtHost.Name = "txtHost";
            txtHost.Size = new System.Drawing.Size(101, 20);
            txtHost.TabIndex = 1;
            // 
            // txtPorta
            // 
            txtPorta.Location = new System.Drawing.Point(123, 52);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new System.Drawing.Size(94, 20);
            txtPorta.TabIndex = 3;
            // 
            // lblPorta
            // 
            lblPorta.AutoSize = true;
            lblPorta.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblPorta.Location = new System.Drawing.Point(123, 32);
            lblPorta.Name = "lblPorta";
            lblPorta.Size = new System.Drawing.Size(50, 17);
            lblPorta.TabIndex = 2;
            lblPorta.Text = "Porta";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(223, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(83, 20);
            txtUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblUsuario.Location = new System.Drawing.Point(223, 32);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(67, 17);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuário";
            // 
            // txtSenha
            // 
            txtSenha.Location = new System.Drawing.Point(312, 52);
            txtSenha.Name = "txtSenha";
            txtSenha.Properties.UseSystemPasswordChar = true;
            txtSenha.Size = new System.Drawing.Size(83, 20);
            txtSenha.TabIndex = 7;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblSenha.Location = new System.Drawing.Point(312, 32);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new System.Drawing.Size(56, 17);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // txtBancoDeDados
            // 
            txtBancoDeDados.Location = new System.Drawing.Point(401, 52);
            txtBancoDeDados.Name = "txtBancoDeDados";
            txtBancoDeDados.Size = new System.Drawing.Size(128, 20);
            txtBancoDeDados.TabIndex = 9;
            // 
            // lblBancoDeDados
            // 
            lblBancoDeDados.AutoSize = true;
            lblBancoDeDados.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblBancoDeDados.Location = new System.Drawing.Point(396, 32);
            lblBancoDeDados.Name = "lblBancoDeDados";
            lblBancoDeDados.Size = new System.Drawing.Size(133, 17);
            lblBancoDeDados.TabIndex = 8;
            lblBancoDeDados.Text = "Banco de Dados";
            // 
            // UCConexaoMyCommerce
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(txtBancoDeDados);
            Controls.Add(lblBancoDeDados);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(txtPorta);
            Controls.Add(lblPorta);
            Controls.Add(txtHost);
            Controls.Add(lblHost);
            Name = "UCConexaoMyCommerce";
            Size = new System.Drawing.Size(542, 541);
            Load += UCConexaoMyCommerce_Load;
            Leave += UCConexaoMyCommerce_Leave;
            ((System.ComponentModel.ISupportInitialize)txtHost.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPorta.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBancoDeDados.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHost;
        private DevExpress.XtraEditors.TextEdit txtHost;
        private DevExpress.XtraEditors.TextEdit txtPorta;
        private System.Windows.Forms.Label lblPorta;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private DevExpress.XtraEditors.TextEdit txtBancoDeDados;
        private System.Windows.Forms.Label lblBancoDeDados;
    }
}
