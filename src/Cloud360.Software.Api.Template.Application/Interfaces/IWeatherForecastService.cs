using Cloud360.Software.Api.Template.Domain.Entities;

namespace Cloud360.Software.Api.Template.Application.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetAllWeatherForecastAsync();
    }
}