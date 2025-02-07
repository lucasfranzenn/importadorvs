namespace Importador.UserControls.Importacao
{
    partial class UCCodigoBarra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCodigoBarra));
            cbImportarCodBarras = new DevExpress.XtraEditors.CheckEdit();
            cbVincularCodBarPorReferencia = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            gcParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarCodBarras.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbVincularCodBarPorReferencia.Properties).BeginInit();
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
            gcParametros.Controls.Add(cbVincularCodBarPorReferencia);
            gcParametros.Controls.Add(cbImportarCodBarras);
            gcParametros.Controls.SetChildIndex(cbImportarCodBarras, 0);
            gcParametros.Controls.SetChildIndex(cbVincularCodBarPorReferencia, 0);
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
            MyC.Tabela = Classes.Constantes.Enums.TabelaMyCommerce.produtosbarcode;
            // 
            // btnObservacao
            // 
            btnObservacao.ImageOptions.Image = Properties.Resources.edittask_16x16;
            btnObservacao.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            // 
            // btnVerificarSintaxeSQL
            // 
            btnVerificarSintaxeSQL.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnVerificarSintaxeSQL.ImageOptions.Image");
            // 
            // cbImportarCodBarras
            // 
            cbImportarCodBarras.EditValue = true;
            cbImportarCodBarras.Location = new System.Drawing.Point(5, 52);
            cbImportarCodBarras.Name = "cbImportarCodBarras";
            cbImportarCodBarras.Properties.Caption = "Importar CodBarras";
            cbImportarCodBarras.Size = new System.Drawing.Size(174, 20);
            cbImportarCodBarras.TabIndex = 19;
            cbImportarCodBarras.Visible = false;
            // 
            // cbVincularCodBarPorReferencia
            // 
            cbVincularCodBarPorReferencia.Location = new System.Drawing.Point(172, 26);
            cbVincularCodBarPorReferencia.Name = "cbVincularCodBarPorReferencia";
            cbVincularCodBarPorReferencia.Properties.Caption = "Vincular CodBar pelo Código de Importção de Dados?";
            cbVincularCodBarPorReferencia.Size = new System.Drawing.Size(281, 20);
            cbVincularCodBarPorReferencia.TabIndex = 20;
            // 
            // UCCodigoBarra
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "UCCodigoBarra";
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            gcParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbImportarCodBarras.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbVincularCodBarPorReferencia.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cbImportarCodBarras;
        private DevExpress.XtraEditors.CheckEdit cbVincularCodBarPorReferencia;
    }
}
