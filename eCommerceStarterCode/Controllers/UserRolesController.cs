using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        //private readonly UserManager<User> _userManager;
        public UserRolesController(UserManager<User> userManager)
        {
            //_userManager = userManager;
        }
        [HttpGet, Authorize]
        public IActionResult GetUserRoles()
        {
            var userIdentity = (ClaimsIdentity)User.Identity;
            var claims = userIdentity.Claims;
            var roleClaimType = userIdentity.RoleClaimType;
            //var roles = claims.Where(c => c.Type == ClaimTypes.Role).ToList();
            var role = claims.Where(c => c.Type == roleClaimType).SingleOrDefault();
            return StatusCode(200, role.Value);
        } 
    }
}
