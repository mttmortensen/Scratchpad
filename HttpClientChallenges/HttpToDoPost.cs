using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class HttpToDoPost
    {
        private readonly HttpClient _client;

        public HttpToDoPost(string url)
        {
            _client = new HttpClient() 
            {
                BaseAddress = new Uri(url)
            };
        }

        public async Task<TodoItem?> PostToDoItem(string title, bool done) 
        {
            // Build the item for POST
            TodoItem item = new TodoItem()
            {
                Title = title,
                Completed = done
            };

            // Serialize the item with json 
            string json = JsonSerializer.Serialize(item);

            // Wrap it in stringContent for HttpContent to be happy
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the POST await request
            var response = await _client.PostAsync("posts", content);

            // Ensure a successfull response is made
            response.EnsureSuccessStatusCode();

            // Read the raw JSON response (await)
            string responseJson = await response.Content.ReadAsStringAsync();

            // Now deserialize (convert) into TodoItem 
            TodoItem? createdItem = JsonSerializer.Deserialize<TodoItem>(responseJson, new JsonSerializerOptions 
            {
                // Important for match JSON keys
                PropertyNameCaseInsensitive = true 
            });

            return createdItem;
        }
    }

    public class TodoItem 
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public bool Completed { get; set; }
    }
}
