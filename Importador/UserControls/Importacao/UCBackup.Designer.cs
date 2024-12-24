namespace Importador.UserControls.Importacao
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
            components = new System.ComponentModel.Container();
            lblDiretorio = new DevExpress.XtraEditors.LabelControl();
            txtDestinoBackup = new DevExpress.XtraEditors.TextEdit();
            btnSelecionarDestino = new DevExpress.XtraEditors.CheckButton();
            gcGridTabelas = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnGerarBackup = new DevExpress.XtraEditors.SimpleButton();
            pbProgresso = new DevExpress.XtraEditors.ProgressBarControl();
            btnObservacao = new DevExpress.XtraEditors.SimpleButton();
            cbEnviarValidacoes = new DevExpress.XtraEditors.CheckEdit();
            gcParametros = new DevExpress.XtraEditors.GroupControl();
            MyC = new Componentes.TabelaMyCommerce(components);
            ((System.ComponentModel.ISupportInitialize)txtDestinoBackup.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcGridTabelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProgresso.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbEnviarValidacoes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            gcParametros.SuspendLayout();
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
            // pbProgresso
            // 
            pbProgresso.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pbProgresso.Location = new System.Drawing.Point(18, 464);
            pbProgresso.Name = "pbProgresso";
            pbProgresso.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            pbProgresso.Properties.Maximum = 6;
            pbProgresso.Properties.ShowTitle = true;
            pbProgresso.Properties.Step = 1;
            pbProgresso.Size = new System.Drawing.Size(518, 26);
            pbProgresso.TabIndex = 5;
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
            // cbEnviarValidacoes
            // 
            cbEnviarValidacoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cbEnviarValidacoes.EditValue = true;
            cbEnviarValidacoes.Location = new System.Drawing.Point(0, 0);
            cbEnviarValidacoes.Name = "cbEnviarValidacoes";
            cbEnviarValidacoes.Properties.Caption = "Enviar validações automatizadas?";
            cbEnviarValidacoes.Size = new System.Drawing.Size(192, 20);
            cbEnviarValidacoes.TabIndex = 19;
            // 
            // gcParametros
            // 
            gcParametros.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            gcParametros.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gcParametros.Controls.Add(cbEnviarValidacoes);
            gcParametros.Location = new System.Drawing.Point(18, 496);
            gcParametros.Name = "gcParametros";
            gcParametros.Size = new System.Drawing.Size(398, 36);
            gcParametros.TabIndex = 20;
            gcParametros.Text = "groupControl1";
            // 
            // MyC
            // 
            MyC.Tabela = Classes.Constantes.Enums.TabelaMyCommerce.backup;
            // 
            // UCBackup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gcParametros);
            Controls.Add(btnObservacao);
            Controls.Add(pbProgresso);
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
            ((System.ComponentModel.ISupportInitialize)pbProgresso.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbEnviarValidacoes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            gcParametros.ResumeLayout(false);
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
        private DevExpress.XtraEditors.ProgressBarControl pbProgresso;
        public DevExpress.XtraEditors.SimpleButton btnObservacao;
        private DevExpress.XtraEditors.CheckEdit cbEnviarValidacoes;
        private DevExpress.XtraEditors.GroupControl gcParametros;
        private Componentes.TabelaMyCommerce MyC;
    }
}
