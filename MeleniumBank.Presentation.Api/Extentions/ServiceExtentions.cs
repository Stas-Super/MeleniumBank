using MeleniumBank.Presentation.Api.Services.Implimentation;
using MeleniumBank.Presentation.Api.Services.Interfaces;

namespace Melenium.Presentation.Api.Extentions
{
    public static class ServiceExtentions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IMeleniumService, MeleniumService>();
        }
    }
}