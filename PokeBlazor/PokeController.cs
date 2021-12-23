using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokeBlazor
{
    public class PokeController : IPokeController
    {
        private readonly HttpClient _httpClient;

        public PokeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            var result = JsonConvert.DeserializeObject<Pokemon>(await _httpClient.GetStringAsync($"pokemon/{name}"));

            if (result.Name.Length == 0)
            {
                return null;
            }

            return result;
        }
    }
}