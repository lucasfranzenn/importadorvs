namespace Importador.UserControls.Importacao
{
    partial class UCProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProdutos));
            cbCriarUnidades = new DevExpress.XtraEditors.CheckEdit();
            cbValidarCodBarras = new DevExpress.XtraEditors.CheckEdit();
            cbCriarTabelaPreco = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            gcParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbCriarUnidades.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbValidarCodBarras.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbCriarTabelaPreco.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblSqlImportacao
            // 
            lblSqlImportacao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblSqlImportacao.Appearance.Options.UseFont = true;
            // 
            // txtSqlImportacao
            // 
            // 
            // gcParametros
            // 
            gcParametros.Controls.Add(cbCriarTabelaPreco);
            gcParametros.Controls.Add(cbValidarCodBarras);
            gcParametros.Controls.Add(cbCriarUnidades);
            gcParametros.Controls.SetChildIndex(cbCriarUnidades, 0);
            gcParametros.Controls.SetChildIndex(cbValidarCodBarras, 0);
            gcParametros.Controls.SetChildIndex(cbCriarTabelaPreco, 0);
            // 
            // btnImportar
            // 
            // 
            // pbImportacao
            // 
            pbImportacao.Properties.DisplayFormat.FormatString = "Nenhum registro importado";
            pbImportacao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // btnResetarSql
            // 
            btnResetarSql.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnResetarSql.ImageOptions.Image");
            // 
            // MyC
            // 
            MyC.Tabela = Classes.Constantes.Enums.TabelaMyCommerce.produtos;
            // 
            // cbCriarUnidades
            // 
            cbCriarUnidades.EditValue = true;
            cbCriarUnidades.Location = new System.Drawing.Point(168, 26);
            cbCriarUnidades.Name = "cbCriarUnidades";
            cbCriarUnidades.Properties.Caption = "Criar unidades via produtos?";
            cbCriarUnidades.Size = new System.Drawing.Size(161, 20);
            cbCriarUnidades.TabIndex = 17;
            // 
            // cbValidarCodBarras
            // 
            cbValidarCodBarras.EditValue = true;
            cbValidarCodBarras.Location = new System.Drawing.Point(335, 26);
            cbValidarCodBarras.Name = "cbValidarCodBarras";
            cbValidarCodBarras.Properties.Caption = "Verificar existência de CodBar?";
            cbValidarCodBarras.Size = new System.Drawing.Size(174, 20);
            cbValidarCodBarras.TabIndex = 18;
            // 
            // cbCriarTabelaPreco
            // 
            cbCriarTabelaPreco.EditValue = true;
            cbCriarTabelaPreco.Location = new System.Drawing.Point(5, 52);
            cbCriarTabelaPreco.Name = "cbCriarTabelaPreco";
            cbCriarTabelaPreco.Properties.Caption = "Criar tabela de preço?";
            cbCriarTabelaPreco.Size = new System.Drawing.Size(136, 20);
            cbCriarTabelaPreco.TabIndex = 19;
            // 
            // UCProdutos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "UCProdutos";
            Load += UCProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            gcParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbCriarUnidades.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbValidarCodBarras.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbCriarTabelaPreco.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cbCriarUnidades;
        private DevExpress.XtraEditors.CheckEdit cbValidarCodBarras;
        private DevExpress.XtraEditors.CheckEdit cbCriarTabelaPreco;
    }
}
