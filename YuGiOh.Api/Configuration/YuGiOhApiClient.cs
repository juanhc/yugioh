using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace YuGiOh.Api.Configuration
{
    public class YuGiOhApiClient
    {
        private readonly HttpClient _http;

        public YuGiOhApiClient(HttpClient http)
            => _http = http;

        public async Task<T> GetCards<T>()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            "https://db.ygoprodeck.com/api/v6/cardinfo.php");

            var result = await _http.SendAsync(request);

            var content = await result.Content.ReadAsStringAsync();

            var cardList = JsonSerializer.Deserialize<T>(content);

            return cardList;
        }
    }
}
