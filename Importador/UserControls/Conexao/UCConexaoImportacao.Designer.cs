namespace Importador.UserControls.Conexao
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
            // 
            // txtSenha
            // 
            // 
            // txtUsuario
            // 
            // 
            // txtPorta
            // 
            // 
            // txtHost
            // 
            // 
            // lblTipoBanco
            // 
            lblTipoBanco.AutoSize = true;
            lblTipoBanco.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            lblTipoBanco.Location = new System.Drawing.Point(16, 82);
            lblTipoBanco.Name = "lblTipoBanco";
            lblTipoBanco.Size = new System.Drawing.Size(196, 17);
            lblTipoBanco.TabIndex = 20;
            lblTipoBanco.Text = "Tipo de Banco de Dados";
            // 
            // cbTipoBanco
            // 
            cbTipoBanco.Location = new System.Drawing.Point(16, 102);
            cbTipoBanco.Name = "cbTipoBanco";
            cbTipoBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbTipoBanco.Properties.Items.AddRange(new object[] { "MySQL", "Firebird", "PostgreSQL", "MS-SQL \\ SQLServer", "Acess", "ConnectionString" });
            cbTipoBanco.Size = new System.Drawing.Size(517, 20);
            cbTipoBanco.TabIndex = 23;
            cbTipoBanco.SelectedValueChanged += cbTipoBanco_SelectedValueChanged;
            // 
            // UCConexaoImportacao
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(cbTipoBanco);
            Controls.Add(lblTipoBanco);
            Name = "UCConexaoImportacao";
            Size = new System.Drawing.Size(542, 541);
            Load += UCConexaoImportacao_Load;
            Leave += UCConexaoImportacao_Leave;
            Controls.SetChildIndex(lblHost, 0);
            Controls.SetChildIndex(txtHost, 0);
            Controls.SetChildIndex(lblPorta, 0);
            Controls.SetChildIndex(txtPorta, 0);
            Controls.SetChildIndex(lblUsuario, 0);
            Controls.SetChildIndex(txtUsuario, 0);
            Controls.SetChildIndex(lblSenha, 0);
            Controls.SetChildIndex(txtSenha, 0);
            Controls.SetChildIndex(lblBancoDeDados, 0);
            Controls.SetChildIndex(txtBancoDeDados, 0);
            Controls.SetChildIndex(lblTipoBanco, 0);
            Controls.SetChildIndex(cbTipoBanco, 0);
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

        private System.Windows.Forms.Label lblTipoBanco;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoBanco;
    }
}
