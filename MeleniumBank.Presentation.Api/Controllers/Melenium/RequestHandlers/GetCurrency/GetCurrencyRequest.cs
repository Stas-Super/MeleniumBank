using MediatR;
using MeleniumBank.Services.Interfaces.Dtos.Melenium.GetAll;

namespace MeleniumBank.Presentation.Api.Controllers.Melenium.RequestHandlers.GetCurrency
{
    public class GetCurrencyRequest : IRequest<Item>
    {
        public GetCurrencyRequest(string currency)
        {
            Currency = currency;
        }

        public string Currency { get; }
    }
}
