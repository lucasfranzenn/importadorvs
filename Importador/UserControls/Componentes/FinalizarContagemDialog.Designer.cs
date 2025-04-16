namespace Importador.UserControls.Componentes
{
    partial class FinalizarContagemDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            txtObservacao = new DevExpress.XtraEditors.MemoEdit();
            btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            lblObservacao = new DevExpress.XtraEditors.LabelControl();
            btnOk = new DevExpress.XtraEditors.SimpleButton();
            directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtObservacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbStatus.Properties).BeginInit();
            SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            directXFormContainerControl1.Controls.Add(txtObservacao);
            directXFormContainerControl1.Controls.Add(btnCancelar);
            directXFormContainerControl1.Controls.Add(lblStatus);
            directXFormContainerControl1.Controls.Add(cbStatus);
            directXFormContainerControl1.Controls.Add(lblObservacao);
            directXFormContainerControl1.Controls.Add(btnOk);
            directXFormContainerControl1.Location = new System.Drawing.Point(1, 31);
            directXFormContainerControl1.Name = "directXFormContainerControl1";
            directXFormContainerControl1.Size = new System.Drawing.Size(291, 154);
            directXFormContainerControl1.TabIndex = 0;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new System.Drawing.Point(86, 39);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new System.Drawing.Size(193, 73);
            txtObservacao.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Location = new System.Drawing.Point(141, 118);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(66, 25);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblStatus
            // 
            lblStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblStatus.Appearance.Options.UseFont = true;
            lblStatus.Location = new System.Drawing.Point(13, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(37, 13);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.EditValue = "1 - Montando SQL";
            cbStatus.Location = new System.Drawing.Point(86, 7);
            cbStatus.Name = "cbStatus";
            cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbStatus.Properties.Items.AddRange(new object[] { "1 - Montando SQL", "3 - Corrigindo SQL" });
            cbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbStatus.Size = new System.Drawing.Size(193, 20);
            cbStatus.TabIndex = 0;
            // 
            // lblObservacao
            // 
            lblObservacao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblObservacao.Appearance.Options.UseFont = true;
            lblObservacao.Location = new System.Drawing.Point(13, 41);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new System.Drawing.Size(67, 13);
            lblObservacao.TabIndex = 8;
            lblObservacao.Text = "Observacao";
            // 
            // btnOk
            // 
            btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOk.Location = new System.Drawing.Point(213, 118);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(66, 25);
            btnOk.TabIndex = 3;
            btnOk.Text = "&Ok";
            // 
            // FinalizarContagemDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ChildControls.Add(directXFormContainerControl1);
            ClientSize = new System.Drawing.Size(293, 186);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FinalizarContagemDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Finalizar Contagem";
            directXFormContainerControl1.ResumeLayout(false);
            directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtObservacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbStatus.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.LabelControl lblObservacao;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        public DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        public DevExpress.XtraEditors.MemoEdit txtObservacao;
    }
}