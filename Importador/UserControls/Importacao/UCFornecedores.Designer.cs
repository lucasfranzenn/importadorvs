namespace Importador.UserControls.Importacao
{
    partial class UCFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFornecedores));
            cbVincularCliForCodImpDados = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            gcParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbVincularCliForCodImpDados.Properties).BeginInit();
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
            gcParametros.Controls.Add(cbVincularCliForCodImpDados);
            gcParametros.Controls.SetChildIndex(cbVincularCliForCodImpDados, 0);
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
            MyC.Tabela = Classes.Constantes.Enums.TabelaMyCommerce.produtosfornecedor;
            // 
            // btnObservacao
            // 
            btnObservacao.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnObservacao.ImageOptions.Image");
            btnObservacao.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            // 
            // btnVerificarSintaxeSQL
            // 
            btnVerificarSintaxeSQL.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVerificarSintaxeSQL.ImageOptions.Image");
            // 
            // cbVincularCliForCodImpDados
            // 
            cbVincularCliForCodImpDados.Location = new System.Drawing.Point(169, 26);
            cbVincularCliForCodImpDados.Name = "cbVincularCliForCodImpDados";
            cbVincularCliForCodImpDados.Properties.Caption = "Vincular pelo Código de Importação de Dados?";
            cbVincularCliForCodImpDados.Size = new System.Drawing.Size(248, 20);
            cbVincularCliForCodImpDados.TabIndex = 17;
            // 
            // UCFornecedores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "UCFornecedores";
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            gcParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbVincularCliForCodImpDados.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cbVincularCliForCodImpDados;
    }
}
