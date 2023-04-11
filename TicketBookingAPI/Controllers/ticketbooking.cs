using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketBookingAPI.Models;

namespace TicketBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ticketbooking : ControllerBase
    {
        private readonly ticketbookingdbContext context;

        public ticketbooking(ticketbookingdbContext context)
        {
            this.context = context;
        }

    }
}
