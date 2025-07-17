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

        public void Get() 
        {
            using(HttpClient client = new HttpClient()) 
            {
                client.GetAsync(client.BaseAddress);
            }
        }
    }
}
