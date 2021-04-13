using GetPokemon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.Tasks;

namespace GetPokemon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();

        [HttpGet("{pokemon}")]
        public async Task<Pokemon> GetPokemon(string pokemon)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));

            var streamTask = client.GetStreamAsync($"https://pokeapi.co/api/v2/pokemon/{pokemon}");

            var stats = await JsonSerializer.DeserializeAsync<Pokemon>(await streamTask);
            return stats;
            
        }
    }
}
