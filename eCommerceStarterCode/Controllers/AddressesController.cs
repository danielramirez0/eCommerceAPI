using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AddressesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet, Authorize]
        public IActionResult GetAllAddressesForUser()
        {
            // var userId = User.FindFirstValue("id");
            //// var userAddresses = _context.UserAddresses.Include(ua => ua.Address).Include(ua => ua.User).Where(ua => ua.User.Id == userId);
            // //var addresses = _context.Addresses.Where(a => a.UserID == userId);
            // // Should return an empty array to handle on the front end
            // //if (addresses.Count() == 0)
            // //////{
            // ////    return NotFound();
            // //}
            // return Ok(userAddresses);
            return Ok();
        }


        [HttpGet("{search}"), Authorize]
        public IActionResult GetByType([FromQuery] string type)
        {
            var userId = User.FindFirstValue("id");
           // var userAddresses = _context.UserAddresses.Include(ua => ua.Address).Include(ua => ua.User).Where(ua => ua.User.Id == userId).Where(ua => ua.Address.type == type);
            return Ok(type);
        }
    }
}
