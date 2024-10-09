namespace Importador.UserControls.Importacao
{
    partial class UCContasAReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCContasAReceber));
            cbVincularPorContato = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            gcParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbVincularPorContato.Properties).BeginInit();
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
            gcParametros.Controls.Add(cbVincularPorContato);
            gcParametros.Controls.SetChildIndex(cbVincularPorContato, 0);
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
            MyC.Tabela = Classes.Constantes.Enums.TabelaMyCommerce.contasareceber;
            // 
            // cbVincularPorContato
            // 
            cbVincularPorContato.Location = new System.Drawing.Point(169, 26);
            cbVincularPorContato.Name = "cbVincularPorContato";
            cbVincularPorContato.Properties.Caption = "Vincular conta pelo campo contato?";
            cbVincularPorContato.Size = new System.Drawing.Size(199, 20);
            cbVincularPorContato.TabIndex = 17;
            cbVincularPorContato.ToolTip = "Se ativo, vincular no campo código o mesmo valor que esta salvo em clientes.contato";
            // 
            // UCContasAReceber
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "UCContasAReceber";
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            gcParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbVincularPorContato.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cbVincularPorContato;
    }
}
