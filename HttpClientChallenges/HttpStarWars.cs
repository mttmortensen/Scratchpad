using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class HttpStarWars
    {
        private readonly HttpClient _client;

        public HttpStarWars(string baseUrl)
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(baseUrl)
            };
        }

        public async Task<string> GetStringAsync(int id) 
        {
            var response = await _client.GetAsync(id + "/");

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;

            string name = root.GetProperty("name").ToString();
            string height = root.GetProperty("height").ToString();
            string birthYear = root.GetProperty("birth_year").ToString();

            return $"Name: {name}, Height: {height} cm, Birth Year: {birthYear}";
        }
    }
}
