using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient; 
using TicketBookingAPI.Models;

namespace TicketBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControllers : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UserControllers(IConfiguration configuration)
        {
            _configuration = configuration;
        }


     /*   [HttpPost]
        [Route("SignUp")]
        public Response signup(User user) 
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            return response;
            
        }*/


    }
}
