using MeleniumBank.Services.Interfaces.Dtos.Melenium.GetAll;

namespace MeleniumBank.Services.Interfaces.Interfaces
{
    public interface IMeleniumService
    {
        Task<GetAllRatesResponseDto> GetRatesAsync();
    }
}
