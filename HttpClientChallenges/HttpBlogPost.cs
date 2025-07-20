using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        public async Task<string?> PostBlogPost(string title, string body) 
        {
            var blogPost = new BlogPost()
            {
                Title = title,
                Body = body
            };

            string jsonString = JsonSerializer.Serialize<BlogPost>(blogPost);

            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("posts", content);

            var stringsAsync = await response.Content.ReadAsStringAsync();

            return stringsAsync;
            
        }
    }

    public class BlogPost 
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
