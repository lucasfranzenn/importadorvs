namespace Importador.UserControls.Importacao
{
    partial class UCProdutosAdicionais
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
            imgVoltar = new DevExpress.XtraEditors.SvgImageBox();
            lblVoltarTela = new DevExpress.XtraEditors.LabelControl();
            tcAdicionais = new DevExpress.XtraTab.XtraTabControl();
            tpEstoque = new DevExpress.XtraTab.XtraTabPage();
            tpSecoes = new DevExpress.XtraTab.XtraTabPage();
            tpGrupos = new DevExpress.XtraTab.XtraTabPage();
            tpSubGrupos = new DevExpress.XtraTab.XtraTabPage();
            tpFabricantes = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)imgVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tcAdicionais).BeginInit();
            tcAdicionais.SuspendLayout();
            SuspendLayout();
            // 
            // imgVoltar
            // 
            imgVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            imgVoltar.Location = new System.Drawing.Point(9, 5);
            imgVoltar.Name = "imgVoltar";
            imgVoltar.Size = new System.Drawing.Size(20, 18);
            imgVoltar.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            imgVoltar.SvgImage = Properties.Resources.previous;
            imgVoltar.TabIndex = 0;
            imgVoltar.ToolTip = "Voltar para importação dos produtos";
            imgVoltar.Click += imgVoltar_Click;
            // 
            // lblVoltarTela
            // 
            lblVoltarTela.Location = new System.Drawing.Point(35, 8);
            lblVoltarTela.Name = "lblVoltarTela";
            lblVoltarTela.Size = new System.Drawing.Size(115, 13);
            lblVoltarTela.TabIndex = 2;
            lblVoltarTela.Text = "Voltar para tela anterior";
            // 
            // tcAdicionais
            // 
            tcAdicionais.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tcAdicionais.Location = new System.Drawing.Point(9, 27);
            tcAdicionais.Name = "tcAdicionais";
            tcAdicionais.SelectedTabPage = tpEstoque;
            tcAdicionais.Size = new System.Drawing.Size(527, 506);
            tcAdicionais.TabIndex = 3;
            tcAdicionais.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tpEstoque, tpSecoes, tpGrupos, tpSubGrupos, tpFabricantes });
            // 
            // tpEstoque
            // 
            tpEstoque.Name = "tpEstoque";
            tpEstoque.Size = new System.Drawing.Size(525, 481);
            tpEstoque.Text = "&Estoque";
            // 
            // tpSecoes
            // 
            tpSecoes.Name = "tpSecoes";
            tpSecoes.Size = new System.Drawing.Size(525, 481);
            tpSecoes.Text = "&Seções";
            // 
            // tpGrupos
            // 
            tpGrupos.Name = "tpGrupos";
            tpGrupos.Size = new System.Drawing.Size(525, 481);
            tpGrupos.Text = "&Grupos";
            // 
            // tpSubGrupos
            // 
            tpSubGrupos.Name = "tpSubGrupos";
            tpSubGrupos.Size = new System.Drawing.Size(525, 481);
            tpSubGrupos.Text = "S&ubGrupos";
            // 
            // tpFabricantes
            // 
            tpFabricantes.Name = "tpFabricantes";
            tpFabricantes.Size = new System.Drawing.Size(525, 481);
            tpFabricantes.Text = "&Fabricantes";
            // 
            // UCProdutosAdicionais
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tcAdicionais);
            Controls.Add(lblVoltarTela);
            Controls.Add(imgVoltar);
            Name = "UCProdutosAdicionais";
            ((System.ComponentModel.ISupportInitialize)imgVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tcAdicionais).EndInit();
            tcAdicionais.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SvgImageBox imgVoltar;
        private DevExpress.XtraEditors.LabelControl lblVoltarTela;
        private DevExpress.XtraTab.XtraTabControl tcAdicionais;
        private DevExpress.XtraTab.XtraTabPage tpEstoque;
        private DevExpress.XtraTab.XtraTabPage tpSecoes;
        private DevExpress.XtraTab.XtraTabPage tpGrupos;
        private DevExpress.XtraTab.XtraTabPage tpSubGrupos;
        private DevExpress.XtraTab.XtraTabPage tpFabricantes;
    }
}
