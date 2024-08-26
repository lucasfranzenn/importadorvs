namespace Importador.User_Controls
{
    partial class UCImplantacao
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
            lblCliente = new DevExpress.XtraEditors.LabelControl();
            txtCliente = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)txtCliente.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCliente.Appearance.Options.UseFont = true;
            lblCliente.Location = new System.Drawing.Point(18, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new System.Drawing.Size(51, 16);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new System.Drawing.Point(18, 50);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new System.Drawing.Size(178, 20);
            txtCliente.TabIndex = 1;
            // 
            // UCImplantacao
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Name = "UCImplantacao";
            Size = new System.Drawing.Size(542, 541);
            ((System.ComponentModel.ISupportInitialize)txtCliente.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCliente;
        private DevExpress.XtraEditors.TextEdit txtCliente;
    }
}
