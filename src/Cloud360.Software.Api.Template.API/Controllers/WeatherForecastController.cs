using Cloud360.Software.Api.Template.API.Controllers.Base;
using Cloud360.Software.Api.Template.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cloud360.Software.Api.Template.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ApiController
    {
        public WeatherForecastController(IMediator mediator) : base(mediator)
        { }

        [HttpGet]
        public async Task<IActionResult> GettAllWeatherForecastAsync()
        => Ok(await this._mediator.Send(new GetAllWeatherForecastQuery()));
    }
}