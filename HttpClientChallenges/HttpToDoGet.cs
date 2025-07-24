using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class HttpToDoGet
    {
        private readonly HttpClient _client;

        public HttpToDoGet(string url)
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };
        }

        public async Task<List<ToDoItem>> GetIncompletedToDos() 
        {

        }
    }
}
