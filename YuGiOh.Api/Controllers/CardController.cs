using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YuGiOh.Api.Configuration;
using YuGiOh.Api.Dto;

namespace YuGiOh.Api.Controllers
{
    [Route("api/card")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly YuGiOhApiClient _http;

        public CardController(YuGiOhApiClient http) => _http = http;

        [Route("")]
        public async Task<ActionResult<IEnumerable<CardDto>>> GetAllCardsAsync(int count)
        {
            try
            {
                var response = await _http.GetCards();

                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}