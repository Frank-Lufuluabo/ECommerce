using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Presentation.Abstractions
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public abstract class ApiBaseController : ControllerBase
    {
        protected readonly ISender Sender;

        protected ApiBaseController(ISender sender)
        {
            Sender = Sender;
        }
    }
}
