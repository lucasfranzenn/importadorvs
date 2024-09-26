using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes.Entidades
{
    public class Implantacao
    {
        public int CodigoImplantacao { get; set; }
        public string RazaoSocialCliente { get; set; }
        public string RamoAtividadeCliente { get; set; }
        public string SistemaAntigo { get; set; }
        public string LinkFormulario { get; set; }
        public string LinkBackup { get; set; }
        public string RegimeEmpresa { get; set; }
        public string NomeResponsavel { get; set; }
        public string EmailResponsavel { get; set; }
        public string TelefoneResponsavel { get; set; }
        public byte ImportarClientes { get; set; }
        public byte ImportarFornecedores { get; set; }
        public byte ImportarContasAPagar { get; set; }
        public byte ImportarContasAReceber { get; set; }
        public bool ImportarProdutos { get; set; }
        public bool ImportarEstoque { get; set; }
        public bool ImportarSecoes { get; set; }
        public bool ImportarGrupos { get; set; }
        public bool ImportarSubGrupos { get; set; }
        public bool ImportarFabricantes { get; set;}
        public bool ImportarGrades { get; set; }
        public bool ImportarLotes { get; set; }
        public string Workflow { get; set; }
    }
}
