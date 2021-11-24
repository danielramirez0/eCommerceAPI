using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eCommerceStarterCode.Models;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/ProductReview")]
    [ApiController]
    public class ProductReviewController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet, Authorize]
        public IActionResult GetProductReview([FromQuery] int id)
        {
            var productReviews = _context.ProductRatings.Where(p => p.ProductId == id).Include(p => p.Review).Include(p => p.Stars);
            if (productReviews == null)
            {
                return NotFound();
            }
            return Ok(productReviews);
        }
        [HttpPost]
        public IActionResult PostAddress([FromBody] ProductRating value)
        {
            _context.ProductRatings.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}