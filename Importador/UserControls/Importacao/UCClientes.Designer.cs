namespace Importador.UserControls.Importacao
{
    partial class UCClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCClientes));
            cbCriarConsumidorFinal = new DevExpress.XtraEditors.CheckEdit();
            cbValidarDocumento = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            gcParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbCriarConsumidorFinal.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbValidarDocumento.Properties).BeginInit();
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
            gcParametros.Controls.Add(cbValidarDocumento);
            gcParametros.Controls.Add(cbCriarConsumidorFinal);
            gcParametros.Controls.SetChildIndex(cbCriarConsumidorFinal, 0);
            gcParametros.Controls.SetChildIndex(cbValidarDocumento, 0);
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
            // cbCriarConsumidorFinal
            // 
            cbCriarConsumidorFinal.Location = new System.Drawing.Point(181, 26);
            cbCriarConsumidorFinal.Name = "cbCriarConsumidorFinal";
            cbCriarConsumidorFinal.Properties.Caption = "Criar consumidor final?";
            cbCriarConsumidorFinal.Size = new System.Drawing.Size(155, 20);
            cbCriarConsumidorFinal.TabIndex = 1;
            // 
            // cbValidarDocumento
            // 
            cbValidarDocumento.Location = new System.Drawing.Point(320, 26);
            cbValidarDocumento.Name = "cbValidarDocumento";
            cbValidarDocumento.Properties.Caption = "Verificar existência de CPF/CNPJ?";
            cbValidarDocumento.Size = new System.Drawing.Size(189, 20);
            cbValidarDocumento.TabIndex = 17;
            // 
            // UCClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "UCClientes";
            Load += UCClientes_Load;
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            gcParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbCriarConsumidorFinal.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbValidarDocumento.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cbCriarConsumidorFinal;
        private DevExpress.XtraEditors.CheckEdit cbValidarDocumento;
    }
}
