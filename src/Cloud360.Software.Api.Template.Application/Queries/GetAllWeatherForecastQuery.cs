using Cloud360.Software.Api.Template.Application.Responses;
using MediatR;

namespace Cloud360.Software.Api.Template.Application.Queries
{
    public class GetAllWeatherForecastQuery : IRequest<IEnumerable<WeatherForecastResponse>>
    { }
}