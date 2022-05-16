using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MoviesFunction.Models
{
	public class Genre
	{
		
            [JsonProperty("id")]
			public int Id;

			[JsonProperty("name")]
			public string Name;
		
	}
}

