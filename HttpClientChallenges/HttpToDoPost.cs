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

        public async Task<ToDoItem?> PostToDoItem(string title, bool done) 
        {
            // Build the item for POST
            ToDoItem item = new ToDoItem()
            {
                Title = title,
                Completed = done
            };

            // Serialize the item with json 
            string json = JsonSerializer.Serialize(item);

            // Wrap it in stringContent for HttpContent to be happy
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the POST await request
            var response = await _client.PostAsync("todos", content);

            // Ensure a successfull response is made
            response.EnsureSuccessStatusCode();

            // Read the raw JSON response (await)
            string responseJson = await response.Content.ReadAsStringAsync();

            // Now deserialize (convert) into ToDoItem 
            ToDoItem? createdItem = JsonSerializer.Deserialize<ToDoItem>(responseJson, new JsonSerializerOptions 
            {
                // Important for match JSON keys
                PropertyNameCaseInsensitive = true 
            });

            return createdItem;
        }

    }
}
