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

        // **************** CHALLENGE 1 **************** // 
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

        // **************** CHALLENGE 2 **************** //
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

        // **************** CHALLENGE 3 **************** //
        // ===== HELPER =====
        private async Task<Pokemon> GetFullPokemon(int? id = null, string pokeName = null) 
        {
            HttpResponseMessage response;
            if (id.HasValue)
            {
                response = await _client.GetAsync($"pokemon/{id}");
            }
            else if (!string.IsNullOrEmpty(pokeName))
            {
                response = await _client.GetAsync($"pokemon/{pokeName}");
            }
            else
            {
                throw new Exception($"Error: Pokemon '{pokeName}' is not found");
            }
            ;

            string json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(json, options);

            return pokemon;

        }
        
        public async Task DisplayPokemonAbilities(string pokeName) 
        {
            Pokemon pokemon = await GetFullPokemon(pokeName: pokeName);

            Console.WriteLine($"Pokemon: {pokemon.Name} (ID: {pokemon.Id})");
            Console.WriteLine($"Abilities: ");
            foreach (PokeAbilitySlots abilitySlot in pokemon.Abilities)
            {
                Console.WriteLine($"Name: {abilitySlot.Ability.Name}");
                Console.WriteLine($"More Info: {abilitySlot.Ability.URL}");
            }
        }

        // **************** CHALLENGE 4 **************** //
        public async Task DisplayTop10PokemonMoves(string pokeName)
        {
            Pokemon pokemon = await GetFullPokemon(pokeName: pokeName);

            Console.WriteLine($"Pokemon: {pokemon.Name} (ID: {pokemon.Id})");
            Console.WriteLine($"Top 10 Moves: ");

            List<PokeMoveSlots> top10 = pokemon.Moves.Take(10).ToList();

            for(int i = 0; i < top10.Count; i++) 
            {
                Console.WriteLine($"{i + 1}. {top10[i].Move.Name}");
            }
        }

        // **************** CHALLENGE 5 **************** //
        public async Task DisplayRandomPokemonStats() 
        {

            Random original151 = new Random();

            Pokemon pokemon = await GetFullPokemon(id: original151.Next(1, 151));

            Console.WriteLine($"Pokemon: {pokemon.Name} (ID: {pokemon.Id})");
            Console.WriteLine($"Stats: ");

            foreach(PokeStatSlots statSlots in pokemon.Stats) 
            {
                Console.WriteLine($"{statSlots.Stat.Name}: {statSlots.Base_Stat}");
            }
        }
    }
}
