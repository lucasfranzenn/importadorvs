namespace Importador.UserControls.Geral
{
    partial class UCExportarDados
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCExportarDados));
            lbSql = new DevExpress.XtraEditors.LabelControl();
            meSql = new DevExpress.XtraEditors.MemoEdit();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            rbBancoImpl = new System.Windows.Forms.RadioButton();
            rbBancoMyc = new System.Windows.Forms.RadioButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            btExportar = new DevExpress.XtraEditors.SimpleButton();
            xtraFolderBrowserDialog1 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(components);
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            txtCaminhoFinal = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)meSql.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCaminhoFinal.Properties).BeginInit();
            SuspendLayout();
            // 
            // lbSql
            // 
            lbSql.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            lbSql.Appearance.Options.UseFont = true;
            lbSql.Location = new System.Drawing.Point(16, 34);
            lbSql.Name = "lbSql";
            lbSql.Size = new System.Drawing.Size(109, 16);
            lbSql.TabIndex = 0;
            lbSql.Text = "Sql Exportação";
            // 
            // meSql
            // 
            meSql.Location = new System.Drawing.Point(16, 62);
            meSql.Name = "meSql";
            meSql.Size = new System.Drawing.Size(505, 109);
            meSql.TabIndex = 1;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(rbBancoImpl);
            panelControl1.Controls.Add(rbBancoMyc);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Location = new System.Drawing.Point(300, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(221, 44);
            panelControl1.TabIndex = 5;
            // 
            // rbBancoImpl
            // 
            rbBancoImpl.AutoSize = true;
            rbBancoImpl.Location = new System.Drawing.Point(130, 23);
            rbBancoImpl.Name = "rbBancoImpl";
            rbBancoImpl.Size = new System.Drawing.Size(80, 17);
            rbBancoImpl.TabIndex = 7;
            rbBancoImpl.TabStop = true;
            rbBancoImpl.Text = "Importação";
            rbBancoImpl.UseVisualStyleBackColor = true;
            // 
            // rbBancoMyc
            // 
            rbBancoMyc.AutoSize = true;
            rbBancoMyc.Location = new System.Drawing.Point(18, 22);
            rbBancoMyc.Name = "rbBancoMyc";
            rbBancoMyc.Size = new System.Drawing.Size(89, 17);
            rbBancoMyc.TabIndex = 6;
            rbBancoMyc.TabStop = true;
            rbBancoMyc.Text = "MyCommerce";
            rbBancoMyc.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(5, 5);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(62, 13);
            labelControl1.TabIndex = 5;
            labelControl1.Text = "Usar base:";
            // 
            // btExportar
            // 
            btExportar.AppearanceHovered.Options.UseBackColor = true;
            btExportar.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btExportar.ImageOptions.Image");
            btExportar.Location = new System.Drawing.Point(406, 179);
            btExportar.Name = "btExportar";
            btExportar.Size = new System.Drawing.Size(115, 37);
            btExportar.TabIndex = 6;
            btExportar.Text = "Exportar";
            btExportar.Click += btExportar_Click;
            // 
            // xtraFolderBrowserDialog1
            // 
            xtraFolderBrowserDialog1.DialogStyle = DevExpress.Utils.CommonDialogs.FolderBrowserDialogStyle.Wide;
            xtraFolderBrowserDialog1.SelectedPath = "xtraFolderBrowserDialog1";
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(366, 187);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(22, 22);
            simpleButton1.TabIndex = 7;
            simpleButton1.Click += simpleButton1_Click;
            // 
            // txtCaminhoFinal
            // 
            txtCaminhoFinal.Location = new System.Drawing.Point(16, 188);
            txtCaminhoFinal.Name = "txtCaminhoFinal";
            txtCaminhoFinal.Size = new System.Drawing.Size(344, 20);
            txtCaminhoFinal.TabIndex = 8;
            // 
            // UCExportarDados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(txtCaminhoFinal);
            Controls.Add(simpleButton1);
            Controls.Add(btExportar);
            Controls.Add(panelControl1);
            Controls.Add(meSql);
            Controls.Add(lbSql);
            Name = "UCExportarDados";
            Size = new System.Drawing.Size(540, 540);
            ((System.ComponentModel.ISupportInitialize)meSql.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCaminhoFinal.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbSql;
        private DevExpress.XtraEditors.MemoEdit meSql;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton rbBancoImpl;
        private System.Windows.Forms.RadioButton rbBancoMyc;
        private DevExpress.XtraEditors.SimpleButton btExportar;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtCaminhoFinal;
    }
}
