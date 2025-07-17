using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HttpClientChallenges
{
    public class HttpGetPokemon
    {
        public HttpGetPokemon(string url)
        {
            new HttpClient()
            {
                BaseAddress = new Uri(url)
            };
        }

        public async Task Get() 
        {
            using(HttpClient client = new HttpClient()) 
            {
                var response = await client.GetAsync(client.BaseAddress);
                string results = await response.Content.ReadAsStringAsync();

                client.Dispose();
            }
        }
    }
}
