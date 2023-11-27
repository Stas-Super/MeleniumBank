using MediatR;
using MeleniumBank.Presentation.Api.Dtos.Melenium.GetAll;
using MeleniumBank.Presentation.Api.Services.Interfaces;

namespace MeleniumBank.Presentation.Api.Controllers.Melenium.RequestHandlers.GetAll
{
    public class GetAllRatesRequestHandler : IRequestHandler<GetAllRatesRequest, GetAllRatesResponseDto>
    {
        private readonly IMeleniumService _meleniumService;

        public GetAllRatesRequestHandler(IMeleniumService meleniumService)
        {
            _meleniumService = meleniumService;
        }

        public async Task<GetAllRatesResponseDto> Handle(GetAllRatesRequest request, CancellationToken cancellationToken)
        {
            return await _meleniumService.GetRatesAsync();
        }
    }
}
