using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class HttpStarWars
    {
        private readonly HttpClient _client;

        public HttpStarWars(string baseUrl)
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(baseUrl)
            };
        }


    }
}
