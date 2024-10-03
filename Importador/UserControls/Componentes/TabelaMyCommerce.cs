using DevExpress.XtraBars.Docking2010;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Importador.Classes.Constantes;

namespace Importador.UserControls.Componentes
{
    public partial class TabelaMyCommerce : Component
    {

        [DefaultValue(null)]
        [Category("Appearance")]
        [Browsable(true)]
        [Description("Define a tabela do MyCommerce que é utilizada")]
        public Enums.TabelaMyCommerce Tabela { get; set; }

        [DefaultValue(null)]
        [Category("Appearance")]
        [Browsable(true)]
        [Description("Define a tela do sistema que está sendo utilizada")]
        public Enums.Tela Tela { get; set; }

        public TabelaMyCommerce()
        {
            InitializeComponent();
        }

        public TabelaMyCommerce(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
