using MeleniumBank.Services.Interfaces.Dtos.Melenium.GetAll;
using MeleniumBank.Services.Interfaces.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MeleniumBank.Infrastructure.Business.Services
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
