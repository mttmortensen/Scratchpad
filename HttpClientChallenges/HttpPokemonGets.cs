using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class HttpPokemonGets
    {
        private readonly HttpClient _client;

        public HttpPokemonGets(string url)
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };
        }
    }
}
