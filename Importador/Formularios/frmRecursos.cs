using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.UserControls.Auxiliar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importador.Formularios
{
    public partial class frmRecursos : DirectXForm
    {
        public frmRecursos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmAuxiliar_Load(object sender, EventArgs e)
        {
            dpBancosDeDados.Controls.Add(null);
            dpFiscal.ControlContainer.Controls.Add(new UCFiscal() { Dock = DockStyle.Fill});
            dpNomenclaturasEncontradas.ControlContainer.Controls.Add(new UCNomenclaturas() { Dock = DockStyle.Fill});
            dpSistemasImportados.ControlContainer.Controls.Add(new UCSistemasImportados() { Dock = DockStyle.Fill});
            // dpSoftwaresUteis.Controls.Add(null);
        }

        private void frmAuxiliar_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO
        }

        private void btnPainelFiscal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dpFiscal.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Hidden) dpFiscal.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }

        private void btnPainelBancosDeDados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dpBancosDeDados.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Hidden) dpBancosDeDados.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }

        private void btnPainelNomenclaturas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dpNomenclaturasEncontradas.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Hidden) dpNomenclaturasEncontradas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }

        private void btnPainelSoftwaresUteis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dpSoftwaresUteis.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Hidden) dpSoftwaresUteis.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }

        private void btnPainelSistemasImportados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dpSistemasImportados.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Hidden) dpSistemasImportados.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }
    }
}