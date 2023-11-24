using MeleniumBank.Infrastructure.Business.Services;
using MeleniumBank.Services.Interfaces.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Melenium.Presentation.Extentions
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