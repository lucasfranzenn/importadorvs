namespace Importador.UserControls.Auxiliar
{
    partial class UCFiscal
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
            tcPrincipal = new DevExpress.XtraTab.XtraTabControl();
            tpImportacao = new DevExpress.XtraTab.XtraTabPage();
            pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            ((System.ComponentModel.ISupportInitialize)tcPrincipal).BeginInit();
            tcPrincipal.SuspendLayout();
            tpImportacao.SuspendLayout();
            SuspendLayout();
            // 
            // tcPrincipal
            // 
            tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            tcPrincipal.Location = new System.Drawing.Point(0, 0);
            tcPrincipal.Name = "tcPrincipal";
            tcPrincipal.SelectedTabPage = tpImportacao;
            tcPrincipal.Size = new System.Drawing.Size(485, 623);
            tcPrincipal.TabIndex = 0;
            tcPrincipal.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tpImportacao });
            // 
            // tpImportacao
            // 
            tpImportacao.Controls.Add(pdfViewer);
            tpImportacao.Name = "tpImportacao";
            tpImportacao.Size = new System.Drawing.Size(483, 598);
            tpImportacao.Text = "PDF Visual Software";
            // 
            // pdfViewer
            // 
            pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            pdfViewer.Location = new System.Drawing.Point(0, 0);
            pdfViewer.Name = "pdfViewer";
            pdfViewer.NavigationPanePageVisibility = DevExpress.XtraPdfViewer.PdfNavigationPanePageVisibility.None;
            pdfViewer.ShowPrintStatusDialog = false;
            pdfViewer.Size = new System.Drawing.Size(483, 598);
            pdfViewer.TabIndex = 0;
            pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToVisible;
            pdfViewer.Load += pdfViewer_Load;
            // 
            // UCFiscal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tcPrincipal);
            Name = "UCFiscal";
            Size = new System.Drawing.Size(485, 623);
            ((System.ComponentModel.ISupportInitialize)tcPrincipal).EndInit();
            tcPrincipal.ResumeLayout(false);
            tpImportacao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcPrincipal;
        private DevExpress.XtraTab.XtraTabPage tpImportacao;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer;
    }
}
