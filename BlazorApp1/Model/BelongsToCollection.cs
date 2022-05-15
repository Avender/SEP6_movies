﻿using Newtonsoft.Json;

namespace MoviesFunction.Models;

public class BelongsToCollection
{
    [JsonProperty("id")]
    public int Id;

    [JsonProperty("name")]
    public object Name;

    [JsonProperty("poster_path")]
    public string PosterPath;

    [JsonProperty("backdrop_path")]
    public string BackdropPath;
}