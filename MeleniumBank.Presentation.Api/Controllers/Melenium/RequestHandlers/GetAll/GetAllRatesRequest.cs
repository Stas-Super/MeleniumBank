using MediatR;
using MeleniumBank.Services.Interfaces.Dtos.Melenium.GetAll;

namespace MeleniumBank.Presentation.Api.Controllers.Melenium.RequestHandlers.GetAll
{
    public class GetAllRatesRequest : IRequest<GetAllRatesResponseDto>
    {
    }
}
