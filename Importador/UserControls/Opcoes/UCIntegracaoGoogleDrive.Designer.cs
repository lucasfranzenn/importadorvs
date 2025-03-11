namespace Importador.UserControls.Opcoes
{
    partial class UCIntegracaoGoogleDrive
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
            btnProcurar = new DevExpress.XtraEditors.SimpleButton();
            lblCaminhoCredencial = new DevExpress.XtraEditors.LabelControl();
            txtCaminhoCredencial = new DevExpress.XtraEditors.TextEdit();
            lblParentFolderID = new DevExpress.XtraEditors.LabelControl();
            txtParentFolderID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)txtCaminhoCredencial.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtParentFolderID.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnProcurar
            // 
            btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnProcurar.Location = new System.Drawing.Point(387, 22);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new System.Drawing.Size(20, 20);
            btnProcurar.TabIndex = 5;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // lblCaminhoCredencial
            // 
            lblCaminhoCredencial.Location = new System.Drawing.Point(3, 3);
            lblCaminhoCredencial.Name = "lblCaminhoCredencial";
            lblCaminhoCredencial.Size = new System.Drawing.Size(221, 13);
            lblCaminhoCredencial.TabIndex = 4;
            lblCaminhoCredencial.Text = "Crendencial de acesso do google drive (JSON)";
            // 
            // txtCaminhoCredencial
            // 
            txtCaminhoCredencial.Location = new System.Drawing.Point(3, 22);
            txtCaminhoCredencial.Name = "txtCaminhoCredencial";
            txtCaminhoCredencial.Size = new System.Drawing.Size(381, 20);
            txtCaminhoCredencial.TabIndex = 3;
            // 
            // lblParentFolderID
            // 
            lblParentFolderID.Location = new System.Drawing.Point(3, 48);
            lblParentFolderID.Name = "lblParentFolderID";
            lblParentFolderID.Size = new System.Drawing.Size(281, 13);
            lblParentFolderID.TabIndex = 6;
            lblParentFolderID.Text = "Id da Pasta onde será upado os arquivos (ParentFolderID)";
            // 
            // txtParentFolderID
            // 
            txtParentFolderID.Location = new System.Drawing.Point(3, 67);
            txtParentFolderID.Name = "txtParentFolderID";
            txtParentFolderID.Size = new System.Drawing.Size(404, 20);
            txtParentFolderID.TabIndex = 7;
            // 
            // UCIntegracaoGoogleDrive
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(txtParentFolderID);
            Controls.Add(lblParentFolderID);
            Controls.Add(btnProcurar);
            Controls.Add(lblCaminhoCredencial);
            Controls.Add(txtCaminhoCredencial);
            Name = "UCIntegracaoGoogleDrive";
            Load += UCIntegracaoGoogleDrive_Load;
            ((System.ComponentModel.ISupportInitialize)txtCaminhoCredencial.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtParentFolderID.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnProcurar;
        private DevExpress.XtraEditors.LabelControl lblCaminhoCredencial;
        private DevExpress.XtraEditors.TextEdit txtCaminhoCredencial;
        private DevExpress.XtraEditors.LabelControl lblParentFolderID;
        private DevExpress.XtraEditors.TextEdit txtParentFolderID;
    }
}
