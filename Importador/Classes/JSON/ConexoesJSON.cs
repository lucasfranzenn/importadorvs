using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DevExpress.Map.Kml.Model;
using static Importador.Classes.VariaveisGlobais;

namespace Importador.Classes.JSON
{
    public partial class ConexoesJson
    {
        [JsonProperty("mycommerce")]
        public Importacao Mycommerce { get; set; }

        [JsonProperty("importacao")]
        public Importacao Importacao { get; set; }
    }

    public partial class Importacao
    {
        [JsonProperty("tipobanco")]
        public string Tipobanco { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("porta")]
        public long Porta { get; set; }

        [JsonProperty("usuario")]
        public string Usuario { get; set; }

        [JsonProperty("senha")]
        public string Senha { get; set; }

        [JsonProperty("banco")]
        public string Banco { get; set; }
    }

    public partial class ConexoesJson
    {
        public static string GetTipoBancoImportacao() => FromJson(File.ReadAllText(PathConexoesJson)).Importacao.Tipobanco;
    }

    public partial class ConexoesJson
    {
        public static ConexoesJson FromJson(string json) => JsonConvert.DeserializeObject<ConexoesJson>(json, Converter.Settings);
    }

    public static class ConexoesJSON
    {
        public static string ToJson(this ConexoesJson self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
