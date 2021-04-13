using System.Text.Json.Serialization;

namespace GetPokemon.Models
{
    public class PokemonStat
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
