using DevExpress.XtraEditors;
using Importador.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes.Entidades
{
    internal class Observacoes
    {
        public Observacoes() { }

        public Observacoes(string tela)
        {
            CodigoImplantacao = Convert.ToInt32(Configuracoes.Default.CodigoImplantacao);
            Empresa = Convert.ToInt32(Configuracoes.Default.Empresa);
            Tela = tela;
        }

        public int? CodigoObservacao { get; set; }
        public int? Empresa { get; set; }
        public int CodigoImplantacao { get; set; }
        public string Tela { get; set; }
        public string Observacao { get; set; } = "";
    }
}
