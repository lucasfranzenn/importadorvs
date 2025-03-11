namespace Importador.UserControls.Auxiliar
{
    partial class UCSoftwaresUteis
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
            gcMain = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)gcMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gcMain
            // 
            gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            gcMain.Location = new System.Drawing.Point(5, 5);
            gcMain.MainView = gridView1;
            gcMain.Name = "gcMain";
            gcMain.Padding = new System.Windows.Forms.Padding(5);
            gcMain.Size = new System.Drawing.Size(414, 363);
            gcMain.TabIndex = 1;
            gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gcMain.Load += gcMain_Load;
            // 
            // gridView1
            // 
            gridView1.GridControl = gcMain;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsFilter.InHeaderSearchMode = DevExpress.XtraGrid.Views.Grid.GridInHeaderSearchMode.TextSearch;
            gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            gridView1.OptionsFind.FindNullPrompt = "Digite o que deseja procurar...";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // UCSoftwaresUteis
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gcMain);
            Name = "UCSoftwaresUteis";
            Padding = new System.Windows.Forms.Padding(5);
            Size = new System.Drawing.Size(424, 373);
            ((System.ComponentModel.ISupportInitialize)gcMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
