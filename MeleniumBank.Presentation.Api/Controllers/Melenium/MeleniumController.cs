using MediatR;
using MeleniumBank.Presentation.Api.Controllers.Melenium.RequestHandlers.GetAll;
using MeleniumBank.Presentation.Api.Controllers.Melenium.RequestHandlers.GetCurrency;
using MeleniumBank.Services.Interfaces.Dtos.Melenium.GetAll;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeleniumBank.Presentation.Api.Controllers.Melenium
{
    [Route("api/melenium")]
    [ApiController]
    public class MeleniumController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MeleniumController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-all")]
        public async Task<GetAllRatesResponseDto> GetAllRatesAsync() =>
            await _mediator.Send(new GetAllRatesRequest());

        [HttpGet("get")]
        public async Task<ActionResult<Item>> GetCurrencyAsync([FromQuery] string currency) =>
            await _mediator.Send(new GetCurrencyRequest(currency));
    }
}
