using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MoviesFunction.Models
{
    public class ProductionCompany
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("logo_path")]
        public object LogoPath;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("origin_country")]
        public string OriginCountry;
    }
}