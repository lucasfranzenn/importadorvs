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

        public override string ToString()
        {
            return $"Server={Host};Port={Porta};User={Usuario};Password={Senha};Database={Banco};";
        }
    }

    public partial class ConexoesJson
    {
        /// <summary>
        /// Retorna a string de conexao do sistema solicitado
        /// </summary>
        /// <param name="sistema">"mycommerce" ou "importacao"</param>
        /// <returns>retornara por padrão a string da importacao</returns>
        public static string GetConnectionString(Sistema sistema) => sistema switch
        {
            Sistema.MyCommerce => FromJson(File.ReadAllText(PathConexoesJson)).Mycommerce.ToString(),
            _ => FromJson(File.ReadAllText(PathConexoesJson)).Importacao.ToString()
        };

        public static string GetTipoBancoImportacao() => FromJson(File.ReadAllText(PathConexoesJson)).Importacao.Tipobanco;
    }

    public partial class ConexoesJson
    {
        public static ConexoesJson FromJson(string json) => JsonConvert.DeserializeObject<ConexoesJson>(json, Converter.Settings);
    }

    public static class ConexoesSerialize
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
