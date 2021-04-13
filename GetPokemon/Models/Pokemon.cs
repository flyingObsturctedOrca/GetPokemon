using System;
using System.Text.Json.Serialization;

namespace GetPokemon.Models
{
    public class Pokemon
    {
        [JsonPropertyName("height")]
        public int Height { get; set; }
        
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stats")]
        public PokemonStats[] Stats { get; set; }
    }
}
