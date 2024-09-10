using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DoctorNearby.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorNearbyServiceController : ControllerBase
    {
        private IMediator? _mediator;
       
        protected IMediator Mediator
        {
            get
            {
                return _mediator ??= HttpContext
                                     .RequestServices
                                     .GetService<IMediator>();
            }
        }
      
    }
}
