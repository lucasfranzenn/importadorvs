namespace Importador.UserControls.Utilitarios
{
    partial class UCPython
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
            gcArquivosPython = new DevExpress.XtraGrid.GridControl();
            gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            txtLog = new DevExpress.XtraEditors.MemoEdit();
            lblLog = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gcArquivosPython).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLog.Properties).BeginInit();
            SuspendLayout();
            // 
            // gcArquivosPython
            // 
            gcArquivosPython.Dock = System.Windows.Forms.DockStyle.Top;
            gcArquivosPython.Location = new System.Drawing.Point(0, 0);
            gcArquivosPython.MainView = gvMain;
            gcArquivosPython.Name = "gcArquivosPython";
            gcArquivosPython.Size = new System.Drawing.Size(556, 443);
            gcArquivosPython.TabIndex = 0;
            gcArquivosPython.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvMain });
            // 
            // gvMain
            // 
            gvMain.GridControl = gcArquivosPython;
            gvMain.Name = "gvMain";
            gvMain.OptionsView.ShowGroupPanel = false;
            // 
            // txtLog
            // 
            txtLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLog.Location = new System.Drawing.Point(0, 467);
            txtLog.Name = "txtLog";
            txtLog.Properties.ReadOnly = true;
            txtLog.Size = new System.Drawing.Size(556, 81);
            txtLog.TabIndex = 1;
            // 
            // lblLog
            // 
            lblLog.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblLog.Appearance.Options.UseFont = true;
            lblLog.Location = new System.Drawing.Point(0, 449);
            lblLog.Name = "lblLog";
            lblLog.Size = new System.Drawing.Size(94, 13);
            lblLog.TabIndex = 10;
            lblLog.Text = "Log de execução";
            // 
            // UCPython
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblLog);
            Controls.Add(txtLog);
            Controls.Add(gcArquivosPython);
            Name = "UCPython";
            Load += UCPython_Load;
            ((System.ComponentModel.ISupportInitialize)gcArquivosPython).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLog.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcArquivosPython;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
        private DevExpress.XtraEditors.MemoEdit txtLog;
        protected DevExpress.XtraEditors.LabelControl lblLog;
    }
}
