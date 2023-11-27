using MeleniumBank.Presentation.Api.Dtos.Melenium.GetAll;

namespace MeleniumBank.Presentation.Api.Services.Interfaces
{
    public interface IMeleniumService
    {
        Task<GetAllRatesResponseDto> GetRatesAsync();
    }
}
