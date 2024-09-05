﻿namespace Importador.UserControls.Conexao
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
            cbTipoBanco.Properties.Items.AddRange(new object[] { "MySQL", "Firebird", "PostgreSQL", "MS-SQL \\ SQLServer", "Acess", "ConnectionString" });
            cbTipoBanco.Size = new System.Drawing.Size(517, 20);
            cbTipoBanco.TabIndex = 23;
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
            Controls.SetChildIndex(lblTipoBanco, 0);
            Controls.SetChildIndex(cbTipoBanco, 0);
            ((System.ComponentModel.ISupportInitialize)cbTipoBanco.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTipoBanco;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoBanco;
    }
}