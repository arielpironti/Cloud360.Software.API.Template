using AutoMapper;
using Cloud360.Software.Api.Template.Application.Interfaces;
using Cloud360.Software.Api.Template.Application.Queries;
using Cloud360.Software.Api.Template.Application.Responses;
using MediatR;

namespace Cloud360.Software.Api.Template.Application.Handlers.QueryHandlers
{
    public class GetAllWeatherForecastQueryHandler : IRequestHandler<GetAllWeatherForecastQuery, IEnumerable<WeatherForecastResponse>>
    {
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly IMapper _mapper;

        public GetAllWeatherForecastQueryHandler(IWeatherForecastService weatherForecastService, IMapper mapper)
        {
            _weatherForecastService = weatherForecastService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WeatherForecastResponse>> Handle(GetAllWeatherForecastQuery request, CancellationToken cancellationToken)
        {
            var weatherForecasts= await _weatherForecastService.GetAllWeatherForecastAsync();
            var weatherForecastsReponse = _mapper.Map<IEnumerable<WeatherForecastResponse>>(weatherForecasts);

            return weatherForecastsReponse;
        }
        
    }
}