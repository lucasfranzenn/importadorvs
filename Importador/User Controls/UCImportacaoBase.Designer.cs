namespace Importador.User_Controls
{
    partial class UCImportacaoBase
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
            lblSqlImportacao = new DevExpress.XtraEditors.LabelControl();
            txtSqlImportacao = new DevExpress.XtraEditors.MemoEdit();
            gcParametros = new DevExpress.XtraEditors.GroupControl();
            btnImportar = new DevExpress.XtraEditors.SimpleButton();
            lblHorarioFimImportacao = new DevExpress.XtraEditors.LabelControl();
            lblHorarioInicioImportacao = new DevExpress.XtraEditors.LabelControl();
            lblFimImportacao = new DevExpress.XtraEditors.LabelControl();
            lblInicioImportacao = new DevExpress.XtraEditors.LabelControl();
            pbImportacao = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblSqlImportacao
            // 
            lblSqlImportacao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblSqlImportacao.Appearance.Options.UseFont = true;
            lblSqlImportacao.Location = new System.Drawing.Point(21, 14);
            lblSqlImportacao.Name = "lblSqlImportacao";
            lblSqlImportacao.Size = new System.Drawing.Size(91, 13);
            lblSqlImportacao.TabIndex = 4;
            lblSqlImportacao.Text = "SQL Importação";
            // 
            // txtSqlImportacao
            // 
            txtSqlImportacao.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            txtSqlImportacao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSqlImportacao.Location = new System.Drawing.Point(21, 33);
            txtSqlImportacao.Name = "txtSqlImportacao";
            txtSqlImportacao.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            txtSqlImportacao.Size = new System.Drawing.Size(506, 337);
            txtSqlImportacao.TabIndex = 3;
            // 
            // gcParametros
            // 
            gcParametros.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gcParametros.Location = new System.Drawing.Point(21, 376);
            gcParametros.Name = "gcParametros";
            gcParametros.Size = new System.Drawing.Size(506, 86);
            gcParametros.TabIndex = 5;
            gcParametros.Text = "Parâmetros";
            // 
            // btnImportar
            // 
            btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnImportar.Location = new System.Drawing.Point(396, 500);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new System.Drawing.Size(131, 32);
            btnImportar.TabIndex = 6;
            btnImportar.Text = "&Importar";
            // 
            // lblHorarioFimImportacao
            // 
            lblHorarioFimImportacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblHorarioFimImportacao.Location = new System.Drawing.Point(143, 519);
            lblHorarioFimImportacao.Name = "lblHorarioFimImportacao";
            lblHorarioFimImportacao.Size = new System.Drawing.Size(103, 13);
            lblHorarioFimImportacao.TabIndex = 14;
            lblHorarioFimImportacao.Text = "01/09/2024 15:00:00";
            // 
            // lblHorarioInicioImportacao
            // 
            lblHorarioInicioImportacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblHorarioInicioImportacao.Location = new System.Drawing.Point(143, 500);
            lblHorarioInicioImportacao.Name = "lblHorarioInicioImportacao";
            lblHorarioInicioImportacao.Size = new System.Drawing.Size(103, 13);
            lblHorarioInicioImportacao.TabIndex = 13;
            lblHorarioInicioImportacao.Text = "28/08/2024 10:00:00";
            // 
            // lblFimImportacao
            // 
            lblFimImportacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblFimImportacao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblFimImportacao.Appearance.Options.UseFont = true;
            lblFimImportacao.Location = new System.Drawing.Point(21, 519);
            lblFimImportacao.Name = "lblFimImportacao";
            lblFimImportacao.Size = new System.Drawing.Size(93, 13);
            lblFimImportacao.TabIndex = 12;
            lblFimImportacao.Text = "Fim Importação:";
            // 
            // lblInicioImportacao
            // 
            lblInicioImportacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblInicioImportacao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblInicioImportacao.Appearance.Options.UseFont = true;
            lblInicioImportacao.Location = new System.Drawing.Point(21, 500);
            lblInicioImportacao.Name = "lblInicioImportacao";
            lblInicioImportacao.Size = new System.Drawing.Size(104, 13);
            lblInicioImportacao.TabIndex = 11;
            lblInicioImportacao.Text = "Inicio Importação:";
            // 
            // pbImportacao
            // 
            pbImportacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pbImportacao.Location = new System.Drawing.Point(21, 468);
            pbImportacao.Name = "pbImportacao";
            pbImportacao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            pbImportacao.Size = new System.Drawing.Size(506, 26);
            pbImportacao.TabIndex = 15;
            // 
            // UCImportacaoBase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pbImportacao);
            Controls.Add(lblHorarioFimImportacao);
            Controls.Add(lblHorarioInicioImportacao);
            Controls.Add(lblFimImportacao);
            Controls.Add(lblInicioImportacao);
            Controls.Add(btnImportar);
            Controls.Add(gcParametros);
            Controls.Add(lblSqlImportacao);
            Controls.Add(txtSqlImportacao);
            Name = "UCImportacaoBase";
            Size = new System.Drawing.Size(556, 548);
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected DevExpress.XtraEditors.LabelControl lblSqlImportacao;
        protected DevExpress.XtraEditors.MemoEdit txtSqlImportacao;
        private DevExpress.XtraEditors.SimpleButton btnImportar;
        public DevExpress.XtraEditors.GroupControl gcParametros;
        private DevExpress.XtraEditors.LabelControl lblHorarioFimImportacao;
        private DevExpress.XtraEditors.LabelControl lblHorarioInicioImportacao;
        private DevExpress.XtraEditors.LabelControl lblFimImportacao;
        private DevExpress.XtraEditors.LabelControl lblInicioImportacao;
        private DevExpress.XtraEditors.ProgressBarControl pbImportacao;
    }
}
