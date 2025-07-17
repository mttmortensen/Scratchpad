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
            // Will always add it to the end
            var response = await _client.GetAsync(id + "/");

            // This is our error checking for the raw json
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            // doing short-hand 'using' syntax here
            // avoids {}
            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;

            // this could be error checked as better practice
            string name = root.GetProperty("name").ToString();
            string height = root.GetProperty("height").ToString();
            string birthYear = root.GetProperty("birth_year").ToString();

            return $"Name: {name}, Height: {height} cm, Birth Year: {birthYear}";
        }
    }
}
