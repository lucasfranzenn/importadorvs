namespace Importador.UserControls.Componentes
{
    partial class GridDataSet
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
            gcRegistros = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            lblTotalLinhas = new DevExpress.XtraEditors.LabelControl();
            btnExportarRegistros = new DevExpress.XtraEditors.CheckButton();
            lblQtdeLinhas = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gcRegistros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gcRegistros
            // 
            gcRegistros.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gcRegistros.Location = new System.Drawing.Point(0, 0);
            gcRegistros.MainView = gridView1;
            gcRegistros.Name = "gcRegistros";
            gcRegistros.Size = new System.Drawing.Size(513, 106);
            gcRegistros.TabIndex = 26;
            gcRegistros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gcRegistros;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.AllowValidationErrors = false;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.PlainText;
            gridView1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // lblTotalLinhas
            // 
            lblTotalLinhas.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblTotalLinhas.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            lblTotalLinhas.Appearance.Options.UseFont = true;
            lblTotalLinhas.Location = new System.Drawing.Point(2, 109);
            lblTotalLinhas.Name = "lblTotalLinhas";
            lblTotalLinhas.Size = new System.Drawing.Size(89, 16);
            lblTotalLinhas.TabIndex = 27;
            lblTotalLinhas.Text = "Total de linhas:";
            // 
            // btnExportarRegistros
            // 
            btnExportarRegistros.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnExportarRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExportarRegistros.ImageOptions.Image = Properties.Resources.up_16x16;
            btnExportarRegistros.Location = new System.Drawing.Point(491, 105);
            btnExportarRegistros.Name = "btnExportarRegistros";
            btnExportarRegistros.Size = new System.Drawing.Size(22, 24);
            btnExportarRegistros.TabIndex = 29;
            btnExportarRegistros.ToolTip = "Exportar registros da tabela";
            btnExportarRegistros.CheckedChanged += btnExportarRegistros_CheckedChanged;
            // 
            // lblQtdeLinhas
            // 
            lblQtdeLinhas.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblQtdeLinhas.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            lblQtdeLinhas.Appearance.Options.UseFont = true;
            lblQtdeLinhas.Location = new System.Drawing.Point(97, 109);
            lblQtdeLinhas.Name = "lblQtdeLinhas";
            lblQtdeLinhas.Size = new System.Drawing.Size(0, 16);
            lblQtdeLinhas.TabIndex = 30;
            // 
            // GridDataSet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblQtdeLinhas);
            Controls.Add(btnExportarRegistros);
            Controls.Add(lblTotalLinhas);
            Controls.Add(gcRegistros);
            Name = "GridDataSet";
            Size = new System.Drawing.Size(513, 128);
            ((System.ComponentModel.ISupportInitialize)gcRegistros).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcRegistros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblTotalLinhas;
        private DevExpress.XtraEditors.CheckButton btnExportarRegistros;
        private DevExpress.XtraEditors.LabelControl lblQtdeLinhas;
    }
}
