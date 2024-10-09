namespace Importador.UserControls.Importacao
{
    partial class UCEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEstoque));
            cbImportarEstoque = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            gcParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarEstoque.Properties).BeginInit();
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
            gcParametros.Controls.Add(cbImportarEstoque);
            gcParametros.Controls.SetChildIndex(cbImportarEstoque, 0);
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
            MyC.Tabela = Classes.Constantes.Enums.TabelaMyCommerce.produtosestoque;
            // 
            // cbImportarEstoque
            // 
            cbImportarEstoque.EditValue = true;
            cbImportarEstoque.Location = new System.Drawing.Point(170, 26);
            cbImportarEstoque.Name = "cbImportarEstoque";
            cbImportarEstoque.Properties.Caption = "Importar Estoque?";
            cbImportarEstoque.Size = new System.Drawing.Size(111, 20);
            cbImportarEstoque.TabIndex = 17;
            cbImportarEstoque.Visible = false;
            // 
            // UCEstoque
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "UCEstoque";
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            gcParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarEstoque.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cbImportarEstoque;
    }
}
