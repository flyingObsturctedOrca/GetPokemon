using System.Text.Json.Serialization;

namespace GetPokemon.Models
{
    public class PokemonStats
    {
        [JsonPropertyName("base_stat")]
        public int Base { get; set; }

        [JsonPropertyName("stat")]
        public PokemonStat Stat { get; set; }


    }
}
