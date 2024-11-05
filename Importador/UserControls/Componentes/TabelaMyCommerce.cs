using System.ComponentModel;
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
