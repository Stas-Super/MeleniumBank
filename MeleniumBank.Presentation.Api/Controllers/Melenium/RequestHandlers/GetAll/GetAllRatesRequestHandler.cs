using MediatR;
using MeleniumBank.Services.Interfaces.Dtos.Melenium.GetAll;
using MeleniumBank.Services.Interfaces.Interfaces;

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
