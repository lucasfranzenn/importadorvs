﻿namespace Importador.UserControls.Importacao
{
    partial class UCBackup
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
            lblDiretorio = new DevExpress.XtraEditors.LabelControl();
            txtDestinoBackup = new DevExpress.XtraEditors.TextEdit();
            btnSelecionarDestino = new DevExpress.XtraEditors.CheckButton();
            gcGridTabelas = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnGerarBackup = new DevExpress.XtraEditors.SimpleButton();
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            btnObservacao = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtDestinoBackup.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcGridTabelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblDiretorio
            // 
            lblDiretorio.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblDiretorio.Appearance.Options.UseFont = true;
            lblDiretorio.Location = new System.Drawing.Point(17, 31);
            lblDiretorio.Name = "lblDiretorio";
            lblDiretorio.Size = new System.Drawing.Size(170, 13);
            lblDiretorio.TabIndex = 0;
            lblDiretorio.Text = "Selecione o destino do backup";
            // 
            // txtDestinoBackup
            // 
            txtDestinoBackup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDestinoBackup.Location = new System.Drawing.Point(17, 50);
            txtDestinoBackup.Name = "txtDestinoBackup";
            txtDestinoBackup.Properties.ReadOnly = true;
            txtDestinoBackup.Size = new System.Drawing.Size(461, 20);
            txtDestinoBackup.TabIndex = 1;
            txtDestinoBackup.KeyDown += txtDestinoBackup_KeyDown;
            // 
            // btnSelecionarDestino
            // 
            btnSelecionarDestino.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSelecionarDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSelecionarDestino.ImageOptions.Image = Properties.Resources.up_16x16;
            btnSelecionarDestino.Location = new System.Drawing.Point(513, 49);
            btnSelecionarDestino.Name = "btnSelecionarDestino";
            btnSelecionarDestino.Size = new System.Drawing.Size(23, 21);
            btnSelecionarDestino.TabIndex = 2;
            btnSelecionarDestino.CheckedChanged += btnSelecionarDestino_CheckedChanged;
            // 
            // gcGridTabelas
            // 
            gcGridTabelas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gcGridTabelas.Location = new System.Drawing.Point(17, 84);
            gcGridTabelas.MainView = gridView1;
            gcGridTabelas.Name = "gcGridTabelas";
            gcGridTabelas.Size = new System.Drawing.Size(519, 374);
            gcGridTabelas.TabIndex = 3;
            gcGridTabelas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gcGridTabelas;
            gridView1.Name = "gridView1";
            // 
            // btnGerarBackup
            // 
            btnGerarBackup.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnGerarBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGerarBackup.Location = new System.Drawing.Point(422, 496);
            btnGerarBackup.Name = "btnGerarBackup";
            btnGerarBackup.Size = new System.Drawing.Size(114, 36);
            btnGerarBackup.TabIndex = 4;
            btnGerarBackup.Text = "&Gerar";
            btnGerarBackup.Click += btnGerarBackup_Click;
            // 
            // progressBarControl1
            // 
            progressBarControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            progressBarControl1.Location = new System.Drawing.Point(18, 464);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            progressBarControl1.Size = new System.Drawing.Size(518, 26);
            progressBarControl1.TabIndex = 5;
            // 
            // btnObservacao
            // 
            btnObservacao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnObservacao.Cursor = System.Windows.Forms.Cursors.Hand;
            btnObservacao.ImageOptions.Image = Properties.Resources.edittask_16x16;
            btnObservacao.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnObservacao.Location = new System.Drawing.Point(484, 49);
            btnObservacao.Name = "btnObservacao";
            btnObservacao.Size = new System.Drawing.Size(23, 21);
            btnObservacao.TabIndex = 18;
            btnObservacao.ToolTip = "Anotações referentes a importação deste módulo";
            btnObservacao.Click += btnObservacao_Click;
            // 
            // UCBackup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnObservacao);
            Controls.Add(progressBarControl1);
            Controls.Add(btnGerarBackup);
            Controls.Add(gcGridTabelas);
            Controls.Add(btnSelecionarDestino);
            Controls.Add(txtDestinoBackup);
            Controls.Add(lblDiretorio);
            Name = "UCBackup";
            Load += UCBackup_Load;
            ((System.ComponentModel.ISupportInitialize)txtDestinoBackup.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcGridTabelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDiretorio;
        private DevExpress.XtraEditors.TextEdit txtDestinoBackup;
        private DevExpress.XtraEditors.CheckButton btnSelecionarDestino;
        private DevExpress.XtraGrid.GridControl gcGridTabelas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnGerarBackup;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        public DevExpress.XtraEditors.SimpleButton btnObservacao;
    }
}
