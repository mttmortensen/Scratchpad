using System;
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

        public async Task<bool> DeleteToDoItem(int id) { }
    }
}
