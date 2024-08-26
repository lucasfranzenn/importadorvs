using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes
{
    public class Utils
    {
        public static void AlteraAba(ref FluentDesignFormContainer container, XtraUserControl userControl)
        {
            container.Controls.Clear();
            userControl.Dock = System.Windows.Forms.DockStyle.Fill;
            container.Controls.Add(userControl);
        }
    }

}
