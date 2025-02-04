using DevExpress.Xpo.Metadata.Helpers;
using Importador.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes.Entidades
{
    public class RegistroDeTempo
    {
        public RegistroDeTempo() { }
        public RegistroDeTempo(string tela)
        {
            CodigoImplantacao = Convert.ToInt32(Configuracoes.Default.CodigoImplantacao);
            Empresa = Convert.ToInt32(Configuracoes.Default.Empresa);
            Operador = Configuracoes.Default.UsuarioLogado;
            Tela = tela;
            Status = (int)Constantes.Enums.RegistrosDeTempoStatus.ContandoTempo;
            DataHoraInicio = Convert.ToDateTime(DateTime.Now.ToString());
        }

        public int? CodigoRegistroDeTempo { get; set; }
        public int? Empresa { get;set; }
        public int CodigoImplantacao { get; set; }
        public string Operador { get; set; }
        public string Tela { get; set; }
        public int Status { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime? DataHoraFim { get; set; } = null;
        public string Observacao { get; set; } = null;
    }
}
