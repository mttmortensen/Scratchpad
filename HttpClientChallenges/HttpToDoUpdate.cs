using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class HttpToDoUpdate
    {
        private readonly HttpClient _client;

        public HttpToDoUpdate(string url)
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };
        }

        public async Task<ToDoItem> UpdateToDoItem(int id, ToDoItem item)
        {
            // Create the updated ToDo
            ToDoItem updatedTodo = new ToDoItem()
            {
                Title = item.Title,
                Completed = item.Completed
            };

            // Serialize the item with json 
            string json = JsonSerializer.Serialize(updatedTodo);

            // Wrap it in stringContent for HttpContent to be happy
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the PUT await request
            var response = await _client.PutAsync($"todos/{id}", content);

            // Ensure a successfull response is made
            response.EnsureSuccessStatusCode();

            // Read the raw JSON response (await)
            string responseJson = await response.Content.ReadAsStringAsync();

            // Now deserialize (convert) into ToDoItem 
            ToDoItem? updatedItem = JsonSerializer.Deserialize<ToDoItem>(responseJson, new JsonSerializerOptions
            {
                // Important for match JSON keys
                PropertyNameCaseInsensitive = true
            });

            return updatedItem;
        }
    }
}
