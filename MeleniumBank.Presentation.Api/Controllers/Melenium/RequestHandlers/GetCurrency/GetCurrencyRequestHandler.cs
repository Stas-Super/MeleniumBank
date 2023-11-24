using MediatR;
using MeleniumBank.Services.Interfaces.Dtos.Melenium.GetAll;
using MeleniumBank.Services.Interfaces.Interfaces;

namespace MeleniumBank.Presentation.Api.Controllers.Melenium.RequestHandlers.GetCurrency
{
    public class GetCurrencyRequestHandler : IRequestHandler<GetCurrencyRequest, Item>
    {
        private readonly IMeleniumService _meleniumService;

        public GetCurrencyRequestHandler(IMeleniumService meleniumService)
        {
            _meleniumService = meleniumService;
        }

        public async Task<Item> Handle(GetCurrencyRequest request, CancellationToken cancellationToken)
        {
            var rates = await _meleniumService.GetRatesAsync();

            var item = rates.Items
                .Where(x => x.Currency == request.Currency)
                .FirstOrDefault();

            return item!;
        }
    }
}
