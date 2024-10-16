using DevExpress.XtraEditors;
using Importador.Properties;
using Importador.UserControls.Componentes;
using System;

namespace Importador.Classes.Entidades
{
    internal class Parametro
    {

        public Parametro() { }

        public Parametro(TabelaMyCommerce myc, CheckEdit parametro)
        {
            CodigoParametro = null;
            CodigoImplantacao = Convert.ToInt32(Configuracoes.Default.CodigoImplantacao);
            Tela = myc.Tabela.ToString();
            NomeParametro = parametro.Name;
            Valor = parametro.Checked;
        }

        public int? CodigoParametro { get; set; }
        public int CodigoImplantacao { get; set; }
        public string Tela { get; set; }
        public string NomeParametro { get; set; }
        public bool Valor { get; set; }
    }
}
