using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            if (!response.IsSuccessStatusCode) 
            {
                return $"Error: Pokemon '{pokeName}' is not found";
            };

            string json = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;

            Pokemon poke = new Pokemon()
            {
                Name = root.GetProperty("name").ToString(),
                Id = root.GetProperty("id").ToString(),
                Base_Experience = root.GetProperty("base_experience").ToString()
            };

            return $"Pokemon: {poke.Name}, ID: {poke.Id}, Base Experience: {poke.Base_Experience}";
        }

        public async Task<string> GetDetailedPokemonInfo(string pokeName) 
        {
            var response = await _client.GetAsync($"pokemon/{pokeName}");

            if (!response.IsSuccessStatusCode)
            {
                return $"Error: Pokemon '{pokeName}' is not found";
            };

            string json = await response.Content.ReadAsStringAsync();

            // I need to be better at understanding what using is doing
            // So no shorthand 
            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                JsonElement root = doc.RootElement;

                Pokemon poke = new Pokemon() 
                {
                    Name = root.GetProperty("name").ToString(),
                    Id = root.GetProperty("id").ToString(),
                    Base_Experience = root.GetProperty("base_experience").ToString(),

                    // Using GetInt32 because these props are ints from the API
                    Height = root.GetProperty("height").GetInt32(),
                    Weight = root.GetProperty("weight").GetInt32()
                };

                // Capitalized word
                poke.Name = poke.Name.First().ToString().ToUpper() + poke.Name.Substring(1);

                return $"Pokemon: {poke.Name} (ID: {poke.Id})\n " +
                    $"Base Experience: {poke.Base_Experience}\n " +
                    $"Height: {poke.Height}\n " +
                    $"Weight: {poke.Weight}";
            };
        }

        public async Task<string> GetPokemonAbilities(string pokeName) 
        {

        }
    }
}
