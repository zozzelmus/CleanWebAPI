using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation
{
    [Route("[controller]")]
    public sealed class BookingController : BaseController
    {
        public BookingController(ISender sender)
            : base(sender)
        {

        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking()
        {
            throw new NotImplementedException();
        }
    }
}
