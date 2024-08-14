using Application.Users.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation
{
    [Route("api/Users")]
    public sealed class UserController : BaseController
    {
        public UserController(ISender sender) 
            : base(sender)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CancellationToken token)
        {
            var command =
                new CreateUserCommand("Brandon Parker",
                    "palados21@gmail.com",
                    "7041231234",
                    null,
                    "123password321");

            var response = await Sender.Send(command, token);
            return Ok(response);
        }
    }
}
