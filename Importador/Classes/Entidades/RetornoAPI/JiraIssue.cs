namespace Importador.Classes.Entidades.RetornoAPI
{
    using System;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class JiraIssue
    {
        [JsonProperty("expand")]
        public string Expand { get; set; }

        [JsonProperty("startAt")]
        public long StartAt { get; set; }

        [JsonProperty("maxResults")]
        public long MaxResults { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("issues")]
        public Issue[] Issues { get; set; }
    }

    public partial class Issue
    {
        [JsonProperty("expand")]
        public string Expand { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("self")]
        public Uri Self { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("fields")]
        public Fields Fields { get; set; }
    }

    public partial class Fields
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("customfield_10070")]
        public Customfield10070 Clientes { get; set; }

        [JsonProperty("customfield_10071")]
        public Customfield10070 Fornecedores { get; set; }

        [JsonProperty("customfield_10072")]
        public Customfield10070 ContasAReceber { get; set; }

        [JsonProperty("customfield_10073")]
        public Customfield10070 ContasAPagar { get; set; }

        [JsonProperty("customfield_10074")]
        public Customfield10070 RegimeTributario { get; set; }

        [JsonProperty("customfield_10075")]
        public string NomeSistema { get; set; }

        [JsonProperty("customfield_10081")]
        public string Responsavel { get; set; }

        [JsonProperty("customfield_10082")]
        public string BancoDeDados { get; set; }

        [JsonProperty("comment")]
        public Comment Comment { get; set; }

        [JsonProperty("customfield_10068")]
        public Customfield10070[] Produtos { get; set; }
    }

    public partial class Comment
    {
        [JsonProperty("comments")]
        public object[] Comments { get; set; }

        [JsonProperty("self")]
        public Uri Self { get; set; }

        [JsonProperty("maxResults")]
        public long MaxResults { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("startAt")]
        public long StartAt { get; set; }
    }

    public partial class Customfield10070
    {
        [JsonProperty("self")]
        public Uri Self { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("child", NullValueHandling = NullValueHandling.Ignore)]
        public Customfield10070 Child { get; set; }
    }

    public partial class JiraIssue
    {
        public static JiraIssue FromJson(string json) => JsonConvert.DeserializeObject<JiraIssue>(json, Importador.Classes.Entidades.RetornoAPI.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this JiraIssue self) => JsonConvert.SerializeObject(self, Importador.Classes.Entidades.RetornoAPI.Converter.Settings);
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

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
