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

        public async Task<string> GetBasicPokemonInfo(string pokeName) 
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

        public async Task<string> GetDetailedPokemonInfo(string pokeName) 
        {
            var response = await _client.GetAsync($"pokemon/{pokeName}");

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            // I need to be better at understanding what using is doing
            // So no shorthand 
            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                JsonElement root = doc.RootElement;
                string name = root.GetProperty("name").ToString();

                // Capitalized word
                name = name.First().ToString().ToUpper() + name.Substring(1);

                string id = root.GetProperty("id").ToString();
                string base_experience = root.GetProperty("base_experience").ToString();

                // trying the different solution from challenge 1
                // Using GetString() instead
                // Why? Chat says it's cleaner for strings
                int height = root.GetProperty("height").GetInt32();
                int weight = root.GetProperty("weight").GetInt32();

                return $"Pokemon: {name} (ID: {id})\n Base Experience: {base_experience}\n Height: {height}\n Weight: {weight}";
            };
        }
    }
}
