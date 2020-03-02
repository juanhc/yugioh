using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using YuGiOh.Api.Dto;

namespace YuGiOh.Api.Configuration
{
    public class YuGiOhApiClient
    {
        private readonly HttpClient _http;

        public YuGiOhApiClient(HttpClient http)
            => _http = http;

        public async Task<IEnumerable<CardDto>> GetCards()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            "https://db.ygoprodeck.com/api/v6/cardinfo.php");

            var result = await _http.SendAsync(request);

            var content = await result.Content.ReadAsStringAsync();

            var cardList = JsonConvert.DeserializeObject<IEnumerable<CardDto>>(content);

            return cardList;
        }
    }
}
