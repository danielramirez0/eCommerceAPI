using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using eCommerceStarterCode.Models;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/SellerProduct")]
    [ApiController]
    public class SellerProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SellerProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet, Authorize]
        public IActionResult GetAllSellerProducts()
        {
            var userId = User.FindFirstValue("id");
            var sellerProducts = _context.SellerProducts.Where(sp => sp.UserId == userId).Include(sp => sp.ProductId);
            if (sellerProducts == null)
            {
                return NotFound();
            }
            return Ok(sellerProducts);
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
