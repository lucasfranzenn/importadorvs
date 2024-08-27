using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Importador.Classes.VariaveisGlobais;

namespace Importador.Classes
{
    public partial class ConsultasJSON
    {
        [JsonProperty("consultas")]
        public List<Consulta> Consultas { get; set; }
    }

    public class Consulta
    {
        [JsonProperty("tabela")]
        public string Tabela { get; set; }

        [JsonProperty("sqlSelect")]
        public string SqlSelect { get; set; }
    }

    public partial class ConsultasJSON
    {
        public static string GetSql(string tabela) => FromJson(File.ReadAllText(PathConsultasJson)).Consultas.Find(c => c.Tabela.Equals(tabela, StringComparison.OrdinalIgnoreCase))?.SqlSelect;
    }

    public partial class ConsultasJSON
    {
        public static ConsultasJSON FromJson(string json) => JsonConvert.DeserializeObject<ConsultasJSON>(json, Converter.Settings);
    }

    public static class ConsultasSerialize
    {
        public static string ToJson(this ConsultasJSON self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
