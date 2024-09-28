using Importador.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes.Entidades
{
    internal class Consultas
    {
        public Consultas(string tabela, string sql)
        {
            CodigoImplantacao = Convert.ToInt32(Configuracoes.Default.CodigoImplantacao);
            Consulta = sql;
            TabelaConsulta = tabela;
        }

        public Consultas() { }
        public int? CodigoConsulta { get; set; } = null;
        public int CodigoImplantacao { get; set; }
        public string TabelaConsulta { get; set; }
        public string Consulta { get; set; }
    }
}
