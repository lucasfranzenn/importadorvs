namespace Importador.UserControls.Opcoes
{
    partial class UCAmbienteGeral
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
            txtDiretorioPastaPython = new DevExpress.XtraEditors.TextEdit();
            lblCaminhoPython = new DevExpress.XtraEditors.LabelControl();
            btnProcurar = new DevExpress.XtraEditors.SimpleButton();
            lblCaminhoSqlPadrao = new DevExpress.XtraEditors.LabelControl();
            txtCaminhoSQLPadrao = new DevExpress.XtraEditors.TextEdit();
            btnProcurarSQLPadrao = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtDiretorioPastaPython.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCaminhoSQLPadrao.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtDiretorioPastaPython
            // 
            txtDiretorioPastaPython.Location = new System.Drawing.Point(3, 22);
            txtDiretorioPastaPython.Name = "txtDiretorioPastaPython";
            txtDiretorioPastaPython.Size = new System.Drawing.Size(381, 20);
            txtDiretorioPastaPython.TabIndex = 0;
            // 
            // lblCaminhoPython
            // 
            lblCaminhoPython.Location = new System.Drawing.Point(3, 3);
            lblCaminhoPython.Name = "lblCaminhoPython";
            lblCaminhoPython.Size = new System.Drawing.Size(251, 13);
            lblCaminhoPython.TabIndex = 1;
            lblCaminhoPython.Text = "Diretório de origem dos arquivos (scripts) em Python";
            // 
            // btnProcurar
            // 
            btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnProcurar.Location = new System.Drawing.Point(387, 22);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new System.Drawing.Size(20, 20);
            btnProcurar.TabIndex = 2;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // lblCaminhoSqlPadrao
            // 
            lblCaminhoSqlPadrao.Location = new System.Drawing.Point(3, 48);
            lblCaminhoSqlPadrao.Name = "lblCaminhoSqlPadrao";
            lblCaminhoSqlPadrao.Size = new System.Drawing.Size(232, 13);
            lblCaminhoSqlPadrao.TabIndex = 3;
            lblCaminhoSqlPadrao.Text = "Caminho do arquivo com as SQL Padrões (JSON)";
            // 
            // txtCaminhoSQLPadrao
            // 
            txtCaminhoSQLPadrao.Location = new System.Drawing.Point(3, 67);
            txtCaminhoSQLPadrao.Name = "txtCaminhoSQLPadrao";
            txtCaminhoSQLPadrao.Size = new System.Drawing.Size(381, 20);
            txtCaminhoSQLPadrao.TabIndex = 4;
            // 
            // btnProcurarSQLPadrao
            // 
            btnProcurarSQLPadrao.Cursor = System.Windows.Forms.Cursors.Hand;
            btnProcurarSQLPadrao.Location = new System.Drawing.Point(387, 67);
            btnProcurarSQLPadrao.Name = "btnProcurarSQLPadrao";
            btnProcurarSQLPadrao.Size = new System.Drawing.Size(20, 20);
            btnProcurarSQLPadrao.TabIndex = 5;
            btnProcurarSQLPadrao.Click += btnProcurarSQLPadrao_Click;
            // 
            // UCAmbienteGeral
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnProcurarSQLPadrao);
            Controls.Add(txtCaminhoSQLPadrao);
            Controls.Add(lblCaminhoSqlPadrao);
            Controls.Add(btnProcurar);
            Controls.Add(lblCaminhoPython);
            Controls.Add(txtDiretorioPastaPython);
            Name = "UCAmbienteGeral";
            Load += UCAmbienteGeral_Load;
            ((System.ComponentModel.ISupportInitialize)txtDiretorioPastaPython.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCaminhoSQLPadrao.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDiretorioPastaPython;
        private DevExpress.XtraEditors.LabelControl lblCaminhoPython;
        private DevExpress.XtraEditors.SimpleButton btnProcurar;
        private DevExpress.XtraEditors.LabelControl lblCaminhoSqlPadrao;
        private DevExpress.XtraEditors.TextEdit txtCaminhoSQLPadrao;
        private DevExpress.XtraEditors.SimpleButton btnProcurarSQLPadrao;
    }
}
