namespace Importador.UserControls.BaseControls
{
    partial class UCBaseConexao
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
            txtBancoDeDados = new DevExpress.XtraEditors.TextEdit();
            lblBancoDeDados = new System.Windows.Forms.Label();
            txtSenha = new DevExpress.XtraEditors.TextEdit();
            lblSenha = new System.Windows.Forms.Label();
            txtUsuario = new DevExpress.XtraEditors.TextEdit();
            lblUsuario = new System.Windows.Forms.Label();
            txtPorta = new DevExpress.XtraEditors.TextEdit();
            lblPorta = new System.Windows.Forms.Label();
            txtHost = new DevExpress.XtraEditors.TextEdit();
            lblHost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtBancoDeDados.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPorta.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHost.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtBancoDeDados
            // 
            txtBancoDeDados.EnterMoveNextControl = true;
            txtBancoDeDados.Location = new System.Drawing.Point(405, 52);
            txtBancoDeDados.Name = "txtBancoDeDados";
            txtBancoDeDados.Size = new System.Drawing.Size(128, 20);
            txtBancoDeDados.TabIndex = 19;
            // 
            // lblBancoDeDados
            // 
            lblBancoDeDados.AutoSize = true;
            lblBancoDeDados.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblBancoDeDados.Location = new System.Drawing.Point(400, 32);
            lblBancoDeDados.Name = "lblBancoDeDados";
            lblBancoDeDados.Size = new System.Drawing.Size(133, 17);
            lblBancoDeDados.TabIndex = 18;
            lblBancoDeDados.Text = "Banco de Dados";
            // 
            // txtSenha
            // 
            txtSenha.EnterMoveNextControl = true;
            txtSenha.Location = new System.Drawing.Point(316, 52);
            txtSenha.Name = "txtSenha";
            txtSenha.Properties.UseSystemPasswordChar = true;
            txtSenha.Size = new System.Drawing.Size(83, 20);
            txtSenha.TabIndex = 17;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblSenha.Location = new System.Drawing.Point(316, 32);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new System.Drawing.Size(56, 17);
            lblSenha.TabIndex = 16;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.EnterMoveNextControl = true;
            txtUsuario.Location = new System.Drawing.Point(227, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(83, 20);
            txtUsuario.TabIndex = 15;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblUsuario.Location = new System.Drawing.Point(227, 32);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(67, 17);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "Usuário";
            // 
            // txtPorta
            // 
            txtPorta.EnterMoveNextControl = true;
            txtPorta.Location = new System.Drawing.Point(127, 52);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new System.Drawing.Size(94, 20);
            txtPorta.TabIndex = 13;
            // 
            // lblPorta
            // 
            lblPorta.AutoSize = true;
            lblPorta.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblPorta.Location = new System.Drawing.Point(127, 32);
            lblPorta.Name = "lblPorta";
            lblPorta.Size = new System.Drawing.Size(50, 17);
            lblPorta.TabIndex = 12;
            lblPorta.Text = "Porta";
            // 
            // txtHost
            // 
            txtHost.EnterMoveNextControl = true;
            txtHost.Location = new System.Drawing.Point(16, 52);
            txtHost.Name = "txtHost";
            txtHost.Size = new System.Drawing.Size(101, 20);
            txtHost.TabIndex = 11;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblHost.Location = new System.Drawing.Point(16, 32);
            lblHost.Name = "lblHost";
            lblHost.Size = new System.Drawing.Size(43, 17);
            lblHost.TabIndex = 10;
            lblHost.Text = "Host";
            // 
            // UCBaseConexao
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
            Name = "UCBaseConexao";
            ((System.ComponentModel.ISupportInitialize)txtBancoDeDados.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPorta.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHost.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DevExpress.XtraEditors.TextEdit txtBancoDeDados;
        public System.Windows.Forms.Label lblBancoDeDados;
        public DevExpress.XtraEditors.TextEdit txtSenha;
        public System.Windows.Forms.Label lblSenha;
        public DevExpress.XtraEditors.TextEdit txtUsuario;
        public System.Windows.Forms.Label lblUsuario;
        public DevExpress.XtraEditors.TextEdit txtPorta;
        public System.Windows.Forms.Label lblPorta;
        public DevExpress.XtraEditors.TextEdit txtHost;
        public System.Windows.Forms.Label lblHost;
    }
}
