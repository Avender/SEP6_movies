using System.Collections;
using Newtonsoft.Json;

namespace BlazorApp1.Module;

[Serializable]
public class MovieEntity
{
    [JsonProperty("adult")]
    public string adult { get; set; }
    [JsonProperty("title")]
    public string title { get; set; }
    [JsonProperty("genre")]
    public Genre[] genre { get; set; }
    [JsonProperty("imdb_id")]
    public string imdb_id { get; set; }
    [JsonProperty("original_language")]
    public string original_language { get; set; }
    [JsonProperty("overview")]
    public string overview { get; set; }
    [JsonProperty("popularity")]
    public string popularity { get; set; }
    [JsonProperty("poster_path")]
    public string poster_path { get; set; }
    [JsonProperty("release_date")]
    public string release_date { get; set; }
    [JsonProperty("revenue")]
    public string revenue { get; set; }
    [JsonProperty("runtime")]
    public string runtime { get; set; }
    [JsonProperty("status")]
    public string status { get; set; }    
    [JsonProperty("vote_average")]
    public string vote_average { get; set; }
    [JsonProperty("production_countries")]
    public Countries[] production_countries { get; set; }
    [JsonProperty("vote_count")]
    public string vote_count { get; set; }
}

public class Genre
{
    [JsonProperty("name")]
    public string name{ get; set; }
}

public class Countries
{
    [JsonProperty("name")]
    public string name{ get; set; }
}