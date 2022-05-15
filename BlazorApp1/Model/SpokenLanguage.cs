using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MoviesFunction.Models
{
    public class SpokenLanguage
    {
        [JsonProperty("english_name")]
        public string EnglishName;

        [JsonProperty("iso_639_1")]
        public string Iso6391;

        [JsonProperty("name")]
        public string Name;
    }
}