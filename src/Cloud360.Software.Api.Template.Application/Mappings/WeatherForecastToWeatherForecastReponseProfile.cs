using AutoMapper;
using Cloud360.Software.Api.Template.Application.Responses;
using Cloud360.Software.Api.Template.Domain.Entities;

namespace Cloud360.Software.Api.Template.Application.Mappings
{
    public class WeatherForecastToWeatherForecastReponseProfile : Profile
    {
        public WeatherForecastToWeatherForecastReponseProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastResponse>();
        }
    }
}