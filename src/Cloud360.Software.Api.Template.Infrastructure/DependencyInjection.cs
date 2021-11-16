using Cloud360.Software.Api.Template.Application.Interfaces;
using Cloud360.Software.Api.Template.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Cloud360.Software.Api.Template.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();

            return services;
        }
    }
}