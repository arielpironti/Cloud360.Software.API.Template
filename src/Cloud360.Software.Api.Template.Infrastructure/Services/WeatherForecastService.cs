using Cloud360.Software.Api.Template.Application.Interfaces;
using Cloud360.Software.Api.Template.Domain.Entities;

namespace Cloud360.Software.Api.Template.Infrastructure.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public Task<IEnumerable<WeatherForecast>> GetAllWeatherForecastAsync()
        {
            var summaries = new[]{
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            var data = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            });

            return Task.FromResult(data);
            
        }
    }
}