namespace Importador.User_Controls
{
    partial class UCConexaoImportacao
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
            lblTipoBanco = new System.Windows.Forms.Label();
            cbTipoBanco = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)txtBancoDeDados.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPorta.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHost.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbTipoBanco.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtBancoDeDados
            // 
            txtBancoDeDados.Location = new System.Drawing.Point(398, 52);
            txtBancoDeDados.Name = "txtBancoDeDados";
            txtBancoDeDados.Size = new System.Drawing.Size(128, 20);
            txtBancoDeDados.TabIndex = 19;
            // 
            // lblBancoDeDados
            // 
            lblBancoDeDados.AutoSize = true;
            lblBancoDeDados.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblBancoDeDados.Location = new System.Drawing.Point(393, 32);
            lblBancoDeDados.Name = "lblBancoDeDados";
            lblBancoDeDados.Size = new System.Drawing.Size(133, 17);
            lblBancoDeDados.TabIndex = 18;
            lblBancoDeDados.Text = "Banco de Dados";
            // 
            // txtSenha
            // 
            txtSenha.Location = new System.Drawing.Point(309, 52);
            txtSenha.Name = "txtSenha";
            txtSenha.Properties.UseSystemPasswordChar = true;
            txtSenha.Size = new System.Drawing.Size(83, 20);
            txtSenha.TabIndex = 17;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblSenha.Location = new System.Drawing.Point(309, 32);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new System.Drawing.Size(56, 17);
            lblSenha.TabIndex = 16;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(220, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(83, 20);
            txtUsuario.TabIndex = 15;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblUsuario.Location = new System.Drawing.Point(220, 32);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(67, 17);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "Usuário";
            // 
            // txtPorta
            // 
            txtPorta.Location = new System.Drawing.Point(120, 52);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new System.Drawing.Size(94, 20);
            txtPorta.TabIndex = 13;
            // 
            // lblPorta
            // 
            lblPorta.AutoSize = true;
            lblPorta.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblPorta.Location = new System.Drawing.Point(120, 32);
            lblPorta.Name = "lblPorta";
            lblPorta.Size = new System.Drawing.Size(50, 17);
            lblPorta.TabIndex = 12;
            lblPorta.Text = "Porta";
            // 
            // txtHost
            // 
            txtHost.Location = new System.Drawing.Point(9, 52);
            txtHost.Name = "txtHost";
            txtHost.Size = new System.Drawing.Size(101, 20);
            txtHost.TabIndex = 11;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblHost.Location = new System.Drawing.Point(9, 32);
            lblHost.Name = "lblHost";
            lblHost.Size = new System.Drawing.Size(43, 17);
            lblHost.TabIndex = 10;
            lblHost.Text = "Host";
            // 
            // lblTipoBanco
            // 
            lblTipoBanco.AutoSize = true;
            lblTipoBanco.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblTipoBanco.Location = new System.Drawing.Point(9, 82);
            lblTipoBanco.Name = "lblTipoBanco";
            lblTipoBanco.Size = new System.Drawing.Size(196, 17);
            lblTipoBanco.TabIndex = 20;
            lblTipoBanco.Text = "Tipo de Banco de Dados";
            // 
            // cbTipoBanco
            // 
            cbTipoBanco.Location = new System.Drawing.Point(9, 102);
            cbTipoBanco.Name = "cbTipoBanco";
            cbTipoBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbTipoBanco.Properties.Items.AddRange(new object[] { "MySQL", "Firebird", "Postgree", "MS-SQL \\ SQLServer", "Acess", "ConnectionString" });
            cbTipoBanco.Size = new System.Drawing.Size(517, 20);
            cbTipoBanco.TabIndex = 23;
            // 
            // UCConexaoImportacao
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(cbTipoBanco);
            Controls.Add(lblTipoBanco);
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
            Name = "UCConexaoImportacao";
            Size = new System.Drawing.Size(542, 541);
            Load += UCConexaoImportacao_Load;
            Leave += UCConexaoImportacao_Leave;
            ((System.ComponentModel.ISupportInitialize)txtBancoDeDados.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPorta.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHost.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbTipoBanco.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBancoDeDados;
        private System.Windows.Forms.Label lblBancoDeDados;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private DevExpress.XtraEditors.TextEdit txtPorta;
        private System.Windows.Forms.Label lblPorta;
        private DevExpress.XtraEditors.TextEdit txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblTipoBanco;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoBanco;
    }
}
