using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MoviesFunction.Models
{
    public class ProductionCountry
    {
        [JsonProperty("iso_3166_1")]
        public string Iso31661;

        [JsonProperty("name")]
        public string Name;
    }
}