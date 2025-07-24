using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class HttpPokemonGets
    {
        private readonly HttpClient _client;

        public HttpPokemonGets(string url)
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };
        }

        public async Task<string> GetPokemonInfo(string pokeName) 
        {
            var response = await _client.GetAsync($"pokemon/{pokeName}");

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;

            string name = root.GetProperty("name").ToString();
            string id = root.GetProperty("id").ToString();
            string base_experience = root.GetProperty("base_experience").ToString();

            return $"Pokemon: {name}, ID: {id}, Base Experience: {base_experience}";
        }
    }
}
