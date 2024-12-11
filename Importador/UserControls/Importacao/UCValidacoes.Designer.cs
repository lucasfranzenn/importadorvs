namespace Importador.UserControls.Importacao
{
    partial class UCValidacoes
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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtLog = new DevExpress.XtraEditors.MemoEdit();
            lblLog = new DevExpress.XtraEditors.LabelControl();
            btnIniciar = new DevExpress.XtraEditors.SimpleButton();
            pbProgresso = new DevExpress.XtraEditors.ProgressBarControl();
            btnAjustar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtLog.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProgresso.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(20, 449);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(349, 13);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "* Os dados validados e relatorios serão enviados na pasta \".\\Validacoes\"";
            // 
            // txtLog
            // 
            txtLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLog.Location = new System.Drawing.Point(20, 34);
            txtLog.Name = "txtLog";
            txtLog.Properties.ReadOnly = true;
            txtLog.Size = new System.Drawing.Size(496, 409);
            txtLog.TabIndex = 2;
            // 
            // lblLog
            // 
            lblLog.Location = new System.Drawing.Point(20, 15);
            lblLog.Name = "lblLog";
            lblLog.Size = new System.Drawing.Size(89, 13);
            lblLog.TabIndex = 4;
            lblLog.Text = "Log de validações:";
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIniciar.Location = new System.Drawing.Point(400, 507);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new System.Drawing.Size(116, 32);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "&Iniciar";
            btnIniciar.Click += btnIniciar_Click;
            // 
            // pbProgresso
            // 
            pbProgresso.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pbProgresso.Location = new System.Drawing.Point(20, 468);
            pbProgresso.Name = "pbProgresso";
            pbProgresso.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            pbProgresso.Properties.ShowTitle = true;
            pbProgresso.Properties.Step = 1;
            pbProgresso.Size = new System.Drawing.Size(496, 33);
            pbProgresso.TabIndex = 6;
            // 
            // btnAjustar
            // 
            btnAjustar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAjustar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAjustar.Location = new System.Drawing.Point(20, 507);
            btnAjustar.Name = "btnAjustar";
            btnAjustar.Size = new System.Drawing.Size(116, 32);
            btnAjustar.TabIndex = 8;
            btnAjustar.Text = "&Ajustar";
            btnAjustar.ToolTip = "Fará o ajuste de algumas das validações (Codigo IBGE)";
            btnAjustar.Click += btnAjustar_Click;
            // 
            // UCValidacoes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnAjustar);
            Controls.Add(pbProgresso);
            Controls.Add(btnIniciar);
            Controls.Add(lblLog);
            Controls.Add(labelControl1);
            Controls.Add(txtLog);
            Name = "UCValidacoes";
            Load += UCValidacoes_Load;
            ((System.ComponentModel.ISupportInitialize)txtLog.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProgresso.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtLog;
        private DevExpress.XtraEditors.LabelControl lblLog;
        private DevExpress.XtraEditors.SimpleButton btnIniciar;
        private DevExpress.XtraEditors.ProgressBarControl pbProgresso;
        private DevExpress.XtraEditors.SimpleButton btnAjustar;
    }
}
