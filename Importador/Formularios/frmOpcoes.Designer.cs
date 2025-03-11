namespace Importador.Formularios
{
    partial class frmOpcoes
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            aceAmbiente = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            aceAmbienteGeral = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            aceIntegracoes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            aceIntegracoesGoogleDrive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            aceIntegracoesJira = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnSair = new System.Windows.Forms.Button();
            directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            pnlPrincipal = new DevExpress.XtraEditors.PanelControl();
            ucAmbienteGeral1 = new Importador.UserControls.Opcoes.UCAmbienteGeral();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlPrincipal).BeginInit();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // treeListColumn1
            // 
            treeListColumn1.Caption = "treeListColumn1";
            treeListColumn1.FieldName = "treeListColumn1";
            treeListColumn1.Name = "treeListColumn1";
            treeListColumn1.Visible = true;
            treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            treeListColumn2.Caption = "treeListColumn2";
            treeListColumn2.FieldName = "treeListColumn2";
            treeListColumn2.Name = "treeListColumn2";
            treeListColumn2.Visible = true;
            treeListColumn2.VisibleIndex = 2;
            // 
            // treeListColumn3
            // 
            treeListColumn3.Caption = "treeListColumn3";
            treeListColumn3.FieldName = "treeListColumn3";
            treeListColumn3.Name = "treeListColumn3";
            treeListColumn3.Visible = true;
            treeListColumn3.VisibleIndex = 1;
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { aceAmbiente, aceIntegracoes });
            accordionControl1.Location = new System.Drawing.Point(0, 0);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            accordionControl1.Size = new System.Drawing.Size(180, 352);
            accordionControl1.TabIndex = 0;
            // 
            // aceAmbiente
            // 
            aceAmbiente.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { aceAmbienteGeral });
            aceAmbiente.Expanded = true;
            aceAmbiente.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] { new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons) });
            aceAmbiente.Name = "aceAmbiente";
            aceAmbiente.Text = "Ambiente";
            // 
            // aceAmbienteGeral
            // 
            aceAmbienteGeral.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] { new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left), new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image) });
            aceAmbienteGeral.Name = "aceAmbienteGeral";
            aceAmbienteGeral.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            aceAmbienteGeral.Text = "Geral";
            aceAmbienteGeral.Click += aceAmbienteGeral_Click;
            // 
            // aceIntegracoes
            // 
            aceIntegracoes.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { aceIntegracoesGoogleDrive, aceIntegracoesJira });
            aceIntegracoes.Expanded = true;
            aceIntegracoes.Name = "aceIntegracoes";
            aceIntegracoes.Text = "Integrações";
            // 
            // aceIntegracoesGoogleDrive
            // 
            aceIntegracoesGoogleDrive.Name = "aceIntegracoesGoogleDrive";
            aceIntegracoesGoogleDrive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            aceIntegracoesGoogleDrive.Text = "Google Drive";
            aceIntegracoesGoogleDrive.Click += aceIntegracoesGoogleDrive_Click;
            // 
            // aceIntegracoesJira
            // 
            aceIntegracoesJira.Name = "aceIntegracoesJira";
            aceIntegracoesJira.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            aceIntegracoesJira.Text = "Jira";
            aceIntegracoesJira.Click += aceIntegracoesJira_Click;
            // 
            // btnSair
            // 
            btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSair.Location = new System.Drawing.Point(-100, -100);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(0, 0);
            btnSair.TabIndex = 1;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // directXFormContainerControl1
            // 
            directXFormContainerControl1.Controls.Add(pnlPrincipal);
            directXFormContainerControl1.Controls.Add(btnSair);
            directXFormContainerControl1.Controls.Add(accordionControl1);
            directXFormContainerControl1.Location = new System.Drawing.Point(1, 31);
            directXFormContainerControl1.Name = "directXFormContainerControl1";
            directXFormContainerControl1.Size = new System.Drawing.Size(630, 352);
            directXFormContainerControl1.TabIndex = 0;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            pnlPrincipal.Controls.Add(ucAmbienteGeral1);
            pnlPrincipal.Location = new System.Drawing.Point(186, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new System.Drawing.Size(441, 349);
            pnlPrincipal.TabIndex = 2;
            pnlPrincipal.ControlRemoved += pnlPrincipal_ControlRemoved;
            // 
            // ucAmbienteGeral1
            // 
            ucAmbienteGeral1.Dock = System.Windows.Forms.DockStyle.Fill;
            ucAmbienteGeral1.Location = new System.Drawing.Point(2, 2);
            ucAmbienteGeral1.Name = "ucAmbienteGeral1";
            ucAmbienteGeral1.Size = new System.Drawing.Size(437, 345);
            ucAmbienteGeral1.TabIndex = 0;
            // 
            // frmOpcoes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnSair;
            ChildControls.Add(directXFormContainerControl1);
            ClientSize = new System.Drawing.Size(632, 384);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            IconOptions.SvgImage = Properties.Resources.properties;
            Name = "frmOpcoes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Opções";
            FormClosing += frmOpcoes_FormClosing;
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            directXFormContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlPrincipal).EndInit();
            pnlPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceAmbiente;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceAmbienteGeral;
        private System.Windows.Forms.Button btnSair;
        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.PanelControl pnlPrincipal;
        private UserControls.Opcoes.UCAmbienteGeral ucAmbienteGeral1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceIntegracoes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceIntegracoesJira;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceIntegracoesGoogleDrive;
    }
}