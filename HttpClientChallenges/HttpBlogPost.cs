using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class HttpBlogPost
    {
        private readonly HttpClient _client;

        public HttpBlogPost(string url)
        {
            _client = new HttpClient() 
            {
                BaseAddress = new Uri(url)
            };
        }

        public async Task PostBlogPost(Dictionary<string, string> blogPost) 
        {

        }
    }
}
