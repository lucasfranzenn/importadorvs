using System;

namespace Importador.Classes.Entidades
{
    public class Implantacao
    {
        public Implantacao(string codigoImp)
        {
            CodigoImplantacao = Convert.ToInt32(codigoImp);
        }

        public Implantacao() { }
        public int CodigoImplantacao { get; set; }
        public string RazaoSocialCliente { get; set; } = string.Empty;
        public string SistemaAntigo { get; set; } = string.Empty;
        public string BancoDeDados { get; set; } = string.Empty;
        public string LinkFormulario { get; set; } = string.Empty;
        public string LinkBackup { get; set; } = string.Empty;
        public int RegimeEmpresa { get; set; } = 0;
        public string NomeResponsavel { get; set; } = string.Empty;
        public byte ImportarClientes { get; set; }
        public byte ImportarFornecedores { get; set; }
        public byte ImportarContasAPagar { get; set; }
        public byte ImportarContasAReceber { get; set; }
        public bool ImportarProdutos { get; set; }
        public bool ImportarEstoque { get; set; }
        public bool ImportarSecoes { get; set; }
        public bool ImportarGrupos { get; set; }
        public bool ImportarSubGrupos { get; set; }
        public bool ImportarFabricantes { get; set; }
        public bool ImportarGrades { get; set; }
        public bool ImportarLotes { get; set; }
        public string Workflow { get; set; } = string.Empty;
    }
}
