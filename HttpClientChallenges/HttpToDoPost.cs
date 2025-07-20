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

        public async Task<string?> PostToDoItem(string title, string body) 
        {
            
        }
    }

    public class TodoItem 
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}
