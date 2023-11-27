using MeleniumBank.Presentation.Api.Dtos.Melenium.GetAll;
using MeleniumBank.Presentation.Api.Services.Interfaces;
using Newtonsoft.Json;

namespace MeleniumBank.Presentation.Api.Services.Implimentation
{
    public class MeleniumService : IMeleniumService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MeleniumService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<GetAllRatesResponseDto> GetRatesAsync()
        {
            var httpClient = _httpClientFactory.CreateClient();

            var response = await httpClient.GetAsync("https://portal.api.bankmillennium.pl/bm/app/portal/views/public/fxrates/getMainFxRates");

            var result = await response.Content.ReadAsStringAsync();

            var rates = JsonConvert.DeserializeObject<GetAllRatesResponseDto>(result);

            return rates!;
        }
    }
}
