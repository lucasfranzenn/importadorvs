using Importador.Classes.Entidades.RetornoAPI;
using Importador.Properties;
using System;
using System.Windows.Forms;

namespace Importador.Classes.Entidades
{
    public class Implantacao
    {
        public Implantacao(string codigoImp)
        {
            CodigoImplantacao = Convert.ToInt32(codigoImp);
            Empresa=Convert.ToInt32(Configuracoes.Default.Empresa);
        }

        public Implantacao(JiraIssue jiraIssue)
        {
            #region Setar Informações do Cliente/Responsável
            CodigoImplantacao = Convert.ToInt32(jiraIssue.Issues[0].Fields.Summary.Split('-')[0].Trim());
            Empresa = Convert.ToInt32(Configuracoes.Default.Empresa);
            RazaoSocialCliente = jiraIssue.Issues[0].Fields.Summary.Split('-')[1].Trim().ToUpper();
            NomeResponsavel = jiraIssue.Issues[0].Fields.Responsavel is null ? "" : jiraIssue.Issues[0].Fields.Responsavel.ToUpper();
            BancoDeDados = jiraIssue.Issues[0].Fields.BancoDeDados is null ? "" : jiraIssue.Issues[0].Fields.BancoDeDados.ToUpper();
            SistemaAntigo = jiraIssue.Issues[0].Fields.NomeSistema.ToUpper();
            LinkFormulario = ". . .";
            LinkBackup = ". . .";
            Workflow = "";
            #endregion

            #region Setar Informações de importação
            RegimeEmpresa= Convert.ToInt32(jiraIssue.Issues[0].Fields.RegimeTributario.Id) == 10079 ? 0 : Convert.ToInt32(jiraIssue.Issues[0].Fields.RegimeTributario.Id) == 10081 ? 1 : 2;
            ImportarClientes = Convert.ToByte(jiraIssue.Issues[0].Fields.Clientes.Id != 10058 ? 0 : jiraIssue.Issues[0].Fields.Clientes.Child.Id != 10061 ? 1 : 2);
            ImportarFornecedores = Convert.ToByte(jiraIssue.Issues[0].Fields.Fornecedores.Id != 10062 ? 0 : jiraIssue.Issues[0].Fields.Clientes.Child.Id != 10061 ? 1 : 2);
            ImportarContasAPagar = Convert.ToByte(jiraIssue.Issues[0].Fields.ContasAPagar.Id != 10068 ? 0 : jiraIssue.Issues[0].Fields.ContasAPagar.Child.Id != 10071 ? 1 : 2);
            ImportarContasAReceber = Convert.ToByte(jiraIssue.Issues[0].Fields.ContasAReceber.Id != 10064 ? 0 : jiraIssue.Issues[0].Fields.ContasAReceber.Child.Id != 10067 ? 1 : 2);
            #endregion

            #region Setar Importação dos Produtos
            if (jiraIssue.Issues[0].Fields.Produtos[0].Id == 10055)
            {
                ImportarProdutos = false;
                return;
            }

            ImportarProdutos = true;
            foreach (var opcao in jiraIssue.Issues[0].Fields.Produtos)
            {

                switch (opcao.Id)
                {
                    case 10072:
                        ImportarSecoes = true;
                        break;
                    case 10073:
                        ImportarGrupos = true; 
                        break;
                    case 10074:
                        ImportarSubGrupos = true;
                        break;
                    case 10075:
                        ImportarFabricantes = true;
                        break;
                    case 10076:
                        ImportarGrades = true;  
                        break;
                    case 10077:
                        ImportarLotes = true;
                        break;
                    case 10078:
                        ImportarEstoque = true;
                        break;
                }
            }
            #endregion
        }

        public Implantacao() { }
        public int CodigoImplantacao { get; set; }
        public int Empresa { get; set; } = Convert.ToInt32(Configuracoes.Default.Empresa);
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
