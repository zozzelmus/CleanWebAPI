using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly ISender Sender;
        protected BaseController(ISender sender) 
        {
            Sender = sender;
        }
    }
}
