using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cloud360.Software.Api.Template.API.Controllers.Base
{
    public abstract class ApiController: ControllerBase
    {
        protected readonly IMediator _mediator;

        protected ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
