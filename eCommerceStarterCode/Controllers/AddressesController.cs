using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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
        public IActionResult GetAddressForUser()
        {
            var userId = User.FindFirstValue("id");
            var addresses = _context.Addresses.Where(a => a.UserID == userId);
            if (addresses.Count() == 0)
            {
                return NotFound();
            }
            return Ok(addresses);
        }
    }
}
