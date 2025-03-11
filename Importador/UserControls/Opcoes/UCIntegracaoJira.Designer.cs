namespace Importador.UserControls.Opcoes
{
    partial class UCIntegracaoJira
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
            txtCredencialJira = new DevExpress.XtraEditors.TextEdit();
            lblParentFolderID = new DevExpress.XtraEditors.LabelControl();
            lblEndpointJira = new DevExpress.XtraEditors.LabelControl();
            txtEndPointJira = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)txtCredencialJira.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEndPointJira.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtCredencialJira
            // 
            txtCredencialJira.Location = new System.Drawing.Point(3, 67);
            txtCredencialJira.Name = "txtCredencialJira";
            txtCredencialJira.Properties.MaxLength = 9999;
            txtCredencialJira.Size = new System.Drawing.Size(418, 20);
            txtCredencialJira.TabIndex = 12;
            // 
            // lblParentFolderID
            // 
            lblParentFolderID.Location = new System.Drawing.Point(3, 48);
            lblParentFolderID.Name = "lblParentFolderID";
            lblParentFolderID.Size = new System.Drawing.Size(235, 13);
            lblParentFolderID.TabIndex = 11;
            lblParentFolderID.Text = "Credencial para autenticação do endpoint (Basic)";
            // 
            // lblEndpointJira
            // 
            lblEndpointJira.Location = new System.Drawing.Point(3, 3);
            lblEndpointJira.Name = "lblEndpointJira";
            lblEndpointJira.Size = new System.Drawing.Size(120, 13);
            lblEndpointJira.TabIndex = 9;
            lblEndpointJira.Text = "URI com endpoint do Jira";
            // 
            // txtEndPointJira
            // 
            txtEndPointJira.Location = new System.Drawing.Point(3, 22);
            txtEndPointJira.Name = "txtEndPointJira";
            txtEndPointJira.Properties.MaxLength = 9999;
            txtEndPointJira.Size = new System.Drawing.Size(418, 20);
            txtEndPointJira.TabIndex = 8;
            // 
            // UCIntegracaoJira
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(txtCredencialJira);
            Controls.Add(lblParentFolderID);
            Controls.Add(lblEndpointJira);
            Controls.Add(txtEndPointJira);
            Name = "UCIntegracaoJira";
            Load += UCIntegracaoJira_Load;
            ((System.ComponentModel.ISupportInitialize)txtCredencialJira.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEndPointJira.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCredencialJira;
        private DevExpress.XtraEditors.LabelControl lblParentFolderID;
        private DevExpress.XtraEditors.LabelControl lblEndpointJira;
        private DevExpress.XtraEditors.TextEdit txtEndPointJira;
    }
}
