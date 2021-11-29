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
    [Route("api/ListItemForSale")]
    [ApiController]
    public class ListItemController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ListItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult PostAddress([FromBody] SellerProduct value)
        {
            _context.SellerProducts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
