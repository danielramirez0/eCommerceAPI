using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using eCommerceStarterCode.Models;

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
        public IActionResult GetAddressForUser([FromQuery] string type)
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Where(u => u.Id == userId).Include(u => u.ShippingAddress).Include(u => u.BillingAddress);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                if (type == "shipping")
                {
                    return Ok(user.Select(u => u.ShippingAddress).SingleOrDefault());
                }
                else if (type == "billing")
                {
                    return Ok(user.Select(u => u.BillingAddress).SingleOrDefault());
                }
                else
                {
                    return Ok(user);
                }
            }
        }

        [HttpPost]
        public IActionResult PostAddress([FromBody]Address value)
        {
            _context.Addresses.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

    }
}
