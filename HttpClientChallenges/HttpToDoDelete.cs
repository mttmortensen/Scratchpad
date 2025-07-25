﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class HttpToDoDelete
    {
        private readonly HttpClient _client; 

        public HttpToDoDelete(string url)
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };
        }

        public async Task<bool> DeleteToDoItem(int id) 
        {
            var response = await _client.DeleteAsync($"todos/{id}");

            response.EnsureSuccessStatusCode();

            // Verifying if the object still exists after deletion
            var verifyReponse = await _client.GetAsync($"todos/{id}");

            var body = await verifyReponse.Content.ReadAsStringAsync();

            if (body.Trim() != "{}") 
            {
                Console.WriteLine($"Todo {id} does not exist. Please try a different ID");
                return false;
            }

            Console.WriteLine($"Delete response status: {response.StatusCode}");
            Console.WriteLine($"Verified: Todo {id} no longer exists.\r\n");
            return true;
        }
    }
}
