namespace Importador.UserControls.Componentes
{
    partial class TempoContado
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
            gcTempo = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnSair = new System.Windows.Forms.Button();
            directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcTempo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            directXFormContainerControl1.Controls.Add(gcTempo);
            directXFormContainerControl1.Location = new System.Drawing.Point(1, 31);
            directXFormContainerControl1.Name = "directXFormContainerControl1";
            directXFormContainerControl1.Size = new System.Drawing.Size(568, 142);
            directXFormContainerControl1.TabIndex = 0;
            // 
            // gcTempo
            // 
            gcTempo.Dock = System.Windows.Forms.DockStyle.Fill;
            gcTempo.Location = new System.Drawing.Point(0, 0);
            gcTempo.MainView = gridView1;
            gcTempo.Name = "gcTempo";
            gcTempo.Size = new System.Drawing.Size(568, 142);
            gcTempo.TabIndex = 0;
            gcTempo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gcTempo;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsDragDrop.AllowDataReordering = false;
            gridView1.OptionsDragDrop.AllowSortedDataDragDrop = false;
            gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnSair
            // 
            btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSair.Location = new System.Drawing.Point(-10, -10);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(0, 0);
            btnSair.TabIndex = 1;
            btnSair.Text = "button1";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // TempoContado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnSair;
            ChildControls.Add(directXFormContainerControl1);
            ChildControls.Add(btnSair);
            ClientSize = new System.Drawing.Size(570, 174);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Name = "TempoContado";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Tempo Contado - ";
            Load += TempoContado_Load;
            directXFormContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcTempo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraGrid.GridControl gcTempo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnSair;
    }
}