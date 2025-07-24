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
                Id = root.GetProperty("id").GetInt32(),
                Base_Experience = root.GetProperty("base_experience").GetInt32()
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
                    Id = root.GetProperty("id").GetInt32(),
                    Base_Experience = root.GetProperty("base_experience").GetInt32(),

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

        private async Task<Pokemon> GetPokemonAbilities(string pokeName) 
        {
            var response = await _client.GetAsync($"pokemon/{pokeName}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error: Pokemon '{pokeName}' is not found");
            }
            ;

            string json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(json, options);

            return pokemon;

        }

        // ===== HELPER =====
        public async Task DisplayPokemonAbilities(string pokeName) 
        {
            Pokemon pokemon = await GetPokemonAbilities(pokeName);

            Console.WriteLine($"Pokemon: {pokemon.Name} (ID: {pokemon.Id})");
            Console.WriteLine($"Abilities: ");
            foreach (PokeAbilitySlots abilitySlot in pokemon.Abilities)
            {
                Console.WriteLine($"Name: {abilitySlot.Ability.Name}");
                Console.WriteLine($"More Info: {abilitySlot.Ability.URL}");
            }
        }
    }
}
