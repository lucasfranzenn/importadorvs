namespace Importador.UserControls.BaseControls
{
    partial class UCBaseImportacao
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
            lblSqlImportacao = new DevExpress.XtraEditors.LabelControl();
            txtSqlImportacao = new DevExpress.XtraEditors.MemoEdit();
            gcParametros = new DevExpress.XtraEditors.GroupControl();
            cbExcluirRegistros = new DevExpress.XtraEditors.CheckEdit();
            btnImportar = new DevExpress.XtraEditors.SimpleButton();
            lblHorarioFimImportacao = new DevExpress.XtraEditors.LabelControl();
            lblHorarioInicioImportacao = new DevExpress.XtraEditors.LabelControl();
            lblFimImportacao = new DevExpress.XtraEditors.LabelControl();
            lblInicioImportacao = new DevExpress.XtraEditors.LabelControl();
            pbImportacao = new DevExpress.XtraEditors.ProgressBarControl();
            btnResetarSql = new DevExpress.XtraEditors.SimpleButton();
            MyC = new Componentes.TabelaMyCommerce(components);
            btnObservacao = new DevExpress.XtraEditors.SimpleButton();
            btnVerificarSintaxeSQL = new DevExpress.XtraEditors.SimpleButton();
            btnContarTempo = new DevExpress.XtraEditors.SimpleButton();
            btnVerTempoContado = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            gcParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbExcluirRegistros.Properties).BeginInit();
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
            txtSqlImportacao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSqlImportacao.Location = new System.Drawing.Point(21, 33);
            txtSqlImportacao.Name = "txtSqlImportacao";
            txtSqlImportacao.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            txtSqlImportacao.Size = new System.Drawing.Size(514, 337);
            txtSqlImportacao.TabIndex = 3;
            // 
            // gcParametros
            // 
            gcParametros.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gcParametros.Controls.Add(cbExcluirRegistros);
            gcParametros.Location = new System.Drawing.Point(21, 376);
            gcParametros.Name = "gcParametros";
            gcParametros.Size = new System.Drawing.Size(514, 86);
            gcParametros.TabIndex = 5;
            gcParametros.Text = "Parâmetros";
            // 
            // cbExcluirRegistros
            // 
            cbExcluirRegistros.EditValue = true;
            cbExcluirRegistros.Location = new System.Drawing.Point(5, 26);
            cbExcluirRegistros.Name = "cbExcluirRegistros";
            cbExcluirRegistros.Properties.Caption = "Excluir registros existentes?";
            cbExcluirRegistros.Size = new System.Drawing.Size(170, 20);
            cbExcluirRegistros.TabIndex = 16;
            // 
            // btnImportar
            // 
            btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnImportar.Location = new System.Drawing.Point(396, 500);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new System.Drawing.Size(139, 32);
            btnImportar.TabIndex = 6;
            btnImportar.Text = "&Importar";
            btnImportar.Click += btnImportar_Click;
            // 
            // lblHorarioFimImportacao
            // 
            lblHorarioFimImportacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblHorarioFimImportacao.Location = new System.Drawing.Point(143, 519);
            lblHorarioFimImportacao.Name = "lblHorarioFimImportacao";
            lblHorarioFimImportacao.Size = new System.Drawing.Size(103, 13);
            lblHorarioFimImportacao.TabIndex = 14;
            lblHorarioFimImportacao.Text = "31/12/9999 23:59:59";
            // 
            // lblHorarioInicioImportacao
            // 
            lblHorarioInicioImportacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblHorarioInicioImportacao.Location = new System.Drawing.Point(143, 500);
            lblHorarioInicioImportacao.Name = "lblHorarioInicioImportacao";
            lblHorarioInicioImportacao.Size = new System.Drawing.Size(103, 13);
            lblHorarioInicioImportacao.TabIndex = 13;
            lblHorarioInicioImportacao.Text = "01/01/1999 00:00:00";
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
            pbImportacao.Properties.DisplayFormat.FormatString = "Nenhum registro importado";
            pbImportacao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            pbImportacao.Properties.PercentView = false;
            pbImportacao.Properties.ShowTitle = true;
            pbImportacao.Properties.Step = 1;
            pbImportacao.Size = new System.Drawing.Size(514, 26);
            pbImportacao.TabIndex = 15;
            // 
            // btnResetarSql
            // 
            btnResetarSql.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnResetarSql.Cursor = System.Windows.Forms.Cursors.Hand;
            btnResetarSql.ImageOptions.Image = Properties.Resources.reset2_16x16;
            btnResetarSql.Location = new System.Drawing.Point(298, 9);
            btnResetarSql.Name = "btnResetarSql";
            btnResetarSql.Size = new System.Drawing.Size(23, 23);
            btnResetarSql.TabIndex = 16;
            btnResetarSql.ToolTip = "Este botão reseta para a sql padrão";
            btnResetarSql.Click += btnResetarSql_Click;
            // 
            // MyC
            // 
            MyC.Tabela = Classes.Constantes.Enums.TabelaMyCommerce.clientes;
            // 
            // btnObservacao
            // 
            btnObservacao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnObservacao.Cursor = System.Windows.Forms.Cursors.Hand;
            btnObservacao.ImageOptions.Image = Properties.Resources.edittask_16x16;
            btnObservacao.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnObservacao.Location = new System.Drawing.Point(356, 9);
            btnObservacao.Name = "btnObservacao";
            btnObservacao.Size = new System.Drawing.Size(23, 23);
            btnObservacao.TabIndex = 17;
            btnObservacao.Text = "&";
            btnObservacao.ToolTip = "Anotações referentes a importação deste módulo";
            btnObservacao.Click += btnObservacao_Click;
            // 
            // btnVerificarSintaxeSQL
            // 
            btnVerificarSintaxeSQL.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnVerificarSintaxeSQL.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVerificarSintaxeSQL.ImageOptions.Image = Properties.Resources.spellcheck_16x16;
            btnVerificarSintaxeSQL.Location = new System.Drawing.Point(327, 9);
            btnVerificarSintaxeSQL.Name = "btnVerificarSintaxeSQL";
            btnVerificarSintaxeSQL.Size = new System.Drawing.Size(23, 23);
            btnVerificarSintaxeSQL.TabIndex = 18;
            btnVerificarSintaxeSQL.ToolTip = "Este botão verifica a sintaxe sql";
            btnVerificarSintaxeSQL.Click += btnVerificarSintaxeSQL_Click;
            // 
            // btnContarTempo
            // 
            btnContarTempo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnContarTempo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnContarTempo.ImageOptions.Image = Properties.Resources.iconsetsigns3_16x16;
            btnContarTempo.Location = new System.Drawing.Point(414, 9);
            btnContarTempo.Name = "btnContarTempo";
            btnContarTempo.Size = new System.Drawing.Size(121, 23);
            btnContarTempo.TabIndex = 19;
            btnContarTempo.Tag = "false";
            btnContarTempo.Text = "Iniciar Contagem";
            btnContarTempo.Click += btnContarTempo_Click;
            // 
            // btnVerTempoContado
            // 
            btnVerTempoContado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnVerTempoContado.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVerTempoContado.ImageOptions.Image = Properties.Resources.showworktimeonly_16x16;
            btnVerTempoContado.Location = new System.Drawing.Point(385, 9);
            btnVerTempoContado.Name = "btnVerTempoContado";
            btnVerTempoContado.Size = new System.Drawing.Size(23, 23);
            btnVerTempoContado.TabIndex = 20;
            // 
            // UCBaseImportacao
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnVerTempoContado);
            Controls.Add(btnContarTempo);
            Controls.Add(btnVerificarSintaxeSQL);
            Controls.Add(btnObservacao);
            Controls.Add(btnResetarSql);
            Controls.Add(pbImportacao);
            Controls.Add(lblHorarioFimImportacao);
            Controls.Add(lblHorarioInicioImportacao);
            Controls.Add(lblFimImportacao);
            Controls.Add(lblInicioImportacao);
            Controls.Add(btnImportar);
            Controls.Add(gcParametros);
            Controls.Add(lblSqlImportacao);
            Controls.Add(txtSqlImportacao);
            Name = "UCBaseImportacao";
            Load += UCBaseImportacao_Load;
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            gcParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbExcluirRegistros.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected DevExpress.XtraEditors.LabelControl lblSqlImportacao;
        protected DevExpress.XtraEditors.MemoEdit txtSqlImportacao;
        public DevExpress.XtraEditors.GroupControl gcParametros;
        private DevExpress.XtraEditors.LabelControl lblFimImportacao;
        private DevExpress.XtraEditors.LabelControl lblInicioImportacao;
        public DevExpress.XtraEditors.SimpleButton btnImportar;
        public DevExpress.XtraEditors.ProgressBarControl pbImportacao;
        public DevExpress.XtraEditors.LabelControl lblHorarioFimImportacao;
        public DevExpress.XtraEditors.LabelControl lblHorarioInicioImportacao;
        private DevExpress.XtraEditors.CheckEdit cbExcluirRegistros;
        public DevExpress.XtraEditors.SimpleButton btnResetarSql;
        public Componentes.TabelaMyCommerce MyC;
        public DevExpress.XtraEditors.SimpleButton btnObservacao;
        public DevExpress.XtraEditors.SimpleButton btnVerificarSintaxeSQL;
        private DevExpress.XtraEditors.SimpleButton btnContarTempo;
        private DevExpress.XtraEditors.SimpleButton btnVerTempoContado;
    }
}
