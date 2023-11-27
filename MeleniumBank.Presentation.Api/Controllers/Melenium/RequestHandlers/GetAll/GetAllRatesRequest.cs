using MediatR;
using MeleniumBank.Presentation.Api.Dtos.Melenium.GetAll;

namespace MeleniumBank.Presentation.Api.Controllers.Melenium.RequestHandlers.GetAll
{
    public class GetAllRatesRequest : IRequest<GetAllRatesResponseDto>
    {
    }
}
