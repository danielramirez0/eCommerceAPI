using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/examples")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ExamplesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // <baseurl>/api/examples/user
        [HttpGet("user"), Authorize]
        public IActionResult GetCurrentUser()
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
