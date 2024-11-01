using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Presentation.Abstractions;

namespace ShoppingCart.Presentation.Controllers
{
  public sealed class UsersController : ApiBaseController
    {
        public UsersController(ISender sender):base(sender) 
        {
            
        }

        [HttpPost("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK,Type=typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest,Type=typeof(ProblemDetails))]

        public async Task<IActionResult> Login()
        {
            return Ok();
        }

        [HttpPost("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]

        public async Task<IActionResult> Register ()
        {
            return Ok();
        }

        [HttpGet("{username}")]
       // [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]

        public async Task<IActionResult> GetUserByUsername([FromRoute] string username,CancellationToken cancellationToken)
        {
            return Ok();
        }

    }
}
