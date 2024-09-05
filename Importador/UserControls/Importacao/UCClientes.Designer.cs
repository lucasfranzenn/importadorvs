﻿namespace Importador.UserControls.Importacao
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
            cbExcluirRegistros = new DevExpress.XtraEditors.CheckEdit();
            cbCriarConsumidor = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).BeginInit();
            gcParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbExcluirRegistros.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbCriarConsumidor.Properties).BeginInit();
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
            gcParametros.Controls.Add(cbCriarConsumidor);
            gcParametros.Controls.Add(cbExcluirRegistros);
            // 
            // btnImportar
            // 
            btnImportar.Click += btnImportar_Click;
            // 
            // pbImportacao
            // 
            pbImportacao.Properties.DisplayFormat.FormatString = "Nenhum registro importado";
            pbImportacao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // cbExcluirRegistros
            // 
            cbExcluirRegistros.Location = new System.Drawing.Point(15, 35);
            cbExcluirRegistros.Name = "cbExcluirRegistros";
            cbExcluirRegistros.Properties.Caption = "Excluir registros existentes?";
            cbExcluirRegistros.Size = new System.Drawing.Size(170, 20);
            cbExcluirRegistros.TabIndex = 0;
            // 
            // cbCriarConsumidor
            // 
            cbCriarConsumidor.Location = new System.Drawing.Point(191, 35);
            cbCriarConsumidor.Name = "cbCriarConsumidor";
            cbCriarConsumidor.Properties.Caption = "Criar consumidor final?";
            cbCriarConsumidor.Size = new System.Drawing.Size(155, 20);
            cbCriarConsumidor.TabIndex = 1;
            // 
            // UCClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "UCClientes";
            Size = new System.Drawing.Size(542, 541);
            Load += UCClientes_Load;
            ((System.ComponentModel.ISupportInitialize)txtSqlImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcParametros).EndInit();
            gcParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImportacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbExcluirRegistros.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbCriarConsumidor.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cbCriarConsumidor;
        private DevExpress.XtraEditors.CheckEdit cbExcluirRegistros;
    }
}