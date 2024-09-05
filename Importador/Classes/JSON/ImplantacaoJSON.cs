using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes.JSON
{
    public partial class ImplantacaoJson
    {
        [JsonProperty("RazaoCliente")]
        public string RazaoCliente { get; set; }

        [JsonProperty("SistemaAntigo")]
        public string SistemaAntigo { get; set; }

        [JsonProperty("LinkFormulario")]
        public Uri LinkFormulario { get; set; }

        [JsonProperty("LinkBackup")]
        public Uri LinkBackup { get; set; }

        [JsonProperty("CodigoImportacao")]
        public int CodigoImportacao { get; set; }

        [JsonProperty("RegimeEmpresa")]
        public int RegimeEmpresa { get; set; }

        [JsonProperty("Responsavel")]
        public Responsavel Responsavel { get; set; }

        [JsonProperty("OpcoesImportar")]
        public OpcoesImportar OpcoesImportar { get; set; }
    }

    public partial class OpcoesImportar
    {
        [JsonProperty("Clientes")]
        public int Clientes { get; set; }

        [JsonProperty("Fornecedores")]
        public int Fornecedores { get; set; }

        [JsonProperty("ContasAPagar")]
        public int ContasAPagar { get; set; }

        [JsonProperty("ContasAReceber")]
        public int ContasAReceber { get; set; }

        [JsonProperty("Estoque")]
        public bool Estoque { get; set; }

        [JsonProperty("Produtos")]
        public Produtos Produtos { get; set; }
    }

    public partial class Produtos
    {
        [JsonProperty("Importar")]
        public bool Importar { get; set; }

        [JsonProperty("Secoes")]
        public bool Secoes { get; set; }

        [JsonProperty("Grupos")]
        public bool Grupos { get; set; }

        [JsonProperty("Subgrupos")]
        public bool Subgrupos { get; set; }

        [JsonProperty("Grades")]
        public bool Grades { get; set; }

        [JsonProperty("Lotes")]
        public bool Lotes { get; set; }
    }

    public partial class Responsavel
    {
        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Telefone")]
        public string Telefone { get; set; }
    }

    public partial class ImplantacaoJson
    {
        public static ImplantacaoJson FromJson(string json) => JsonConvert.DeserializeObject<ImplantacaoJson>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ImplantacaoJson self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
