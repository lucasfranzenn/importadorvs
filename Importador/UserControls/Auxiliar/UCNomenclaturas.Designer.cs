namespace Importador.UserControls.Auxiliar
{
    partial class UCNomenclaturas
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
            gcMain.Size = new System.Drawing.Size(402, 347);
            gcMain.TabIndex = 0;
            gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gcMain;
            gridView1.Name = "gridView1";
            gridView1.NewItemRowText = "Adicionar nova nomenclatura";
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            gridView1.RowUpdated += gridView1_RowUpdated;
            // 
            // UCNomenclaturas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(gcMain);
            Name = "UCNomenclaturas";
            Padding = new System.Windows.Forms.Padding(5);
            Size = new System.Drawing.Size(412, 357);
            Load += UCNomenclaturas_Load;
            ((System.ComponentModel.ISupportInitialize)gcMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
