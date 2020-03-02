using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using YuGiOh.Api.Commands;

namespace YuGiOh.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SeedController(IMediator mediator) => _mediator = mediator;

        [HttpGet("")]
        public async Task<ActionResult<bool>> Seed() => await _mediator.Send(new SeedDatabaseCommand());
    }
}