namespace Importador.UserControls.Utilitarios
{
    partial class UCBuscaColuna
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
            lblBuscarColuna = new DevExpress.XtraEditors.LabelControl();
            txtColuna = new DevExpress.XtraEditors.TextEdit();
            btnProcurar = new DevExpress.XtraEditors.SimpleButton();
            gcGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)txtColuna.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // lblBuscarColuna
            // 
            lblBuscarColuna.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            lblBuscarColuna.Appearance.Options.UseFont = true;
            lblBuscarColuna.Location = new System.Drawing.Point(13, 24);
            lblBuscarColuna.Name = "lblBuscarColuna";
            lblBuscarColuna.Size = new System.Drawing.Size(186, 18);
            lblBuscarColuna.TabIndex = 0;
            lblBuscarColuna.Text = "Buscar coluna que tenha:";
            // 
            // txtColuna
            // 
            txtColuna.EnterMoveNextControl = true;
            txtColuna.Location = new System.Drawing.Point(10, 48);
            txtColuna.Name = "txtColuna";
            txtColuna.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            txtColuna.Properties.Appearance.Options.UseFont = true;
            txtColuna.Properties.AutoHeight = false;
            txtColuna.Size = new System.Drawing.Size(380, 42);
            txtColuna.TabIndex = 1;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new System.Drawing.Point(396, 48);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new System.Drawing.Size(147, 42);
            btnProcurar.TabIndex = 2;
            btnProcurar.Text = "&Procurar";
            btnProcurar.Click += btnProcurar_Click;
            // 
            // gcGrid
            // 
            gcGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            gcGrid.Location = new System.Drawing.Point(10, 96);
            gcGrid.MainView = gridView1;
            gcGrid.Name = "gcGrid";
            gcGrid.Size = new System.Drawing.Size(536, 442);
            gcGrid.TabIndex = 3;
            gcGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gcGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            // 
            // UCBuscaColuna
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gcGrid);
            Controls.Add(btnProcurar);
            Controls.Add(txtColuna);
            Controls.Add(lblBuscarColuna);
            Name = "UCBuscaColuna";
            Padding = new System.Windows.Forms.Padding(10);
            Size = new System.Drawing.Size(556, 548);
            Load += UCBuscaColuna_Load;
            ((System.ComponentModel.ISupportInitialize)txtColuna.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBuscarColuna;
        private DevExpress.XtraEditors.TextEdit txtColuna;
        private DevExpress.XtraEditors.SimpleButton btnProcurar;
        private DevExpress.XtraGrid.GridControl gcGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
