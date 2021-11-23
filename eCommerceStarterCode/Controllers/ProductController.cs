using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using eCommerceStarterCode.Models;
using eCommerceStarterCode.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products;
            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _context.Products.Where(p => p.Id == id).SingleOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


        [HttpGet("reviews/{id}")]
        public IActionResult GetReviewsForProduct(int id)
        {
            var reviews = _context.ProductRatings.Where(pr => pr.ProductId == id).Include(pr => pr.Product).Include(pr => pr.User);
            return Ok(reviews);
        }


        [HttpPost("reviews/{id}"), Authorize]
        public IActionResult AddReviewForProduct(int id)
        {
            var userId = User.FindFirstValue("id");
            var reviews = _context.ProductRatings.Where(pr => pr.ProductId == id);
            return Ok(reviews);
        }


        [HttpPost, Authorize]
        public IActionResult AddProduct([FromBody] Product product)
        {
            if (User.IsInRole("Seller"))
            {
            _context.Products.Add(product);
            _context.SaveChanges();
            return StatusCode(201, product);
            }
            else
            {
                return Unauthorized(User);
            }
        }


        [HttpGet("category/{category}")]
        public IActionResult GetProductsByCategory(string category)
        {

            var products = _context.Products;
            if (products == null)
            {
                return NotFound();
            }
            var product = _context.Products.Where(p => p.Category.Name == category);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);

        }

        [HttpGet("name/{name}")]
        public IActionResult GetProductsByName(string name)
        {

            var products = _context.Products;
            if (products == null)
            {
                return NotFound();
            }
            var product = _context.Products.Where(p => p.Name == name);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);

        }


        [HttpDelete("{id}"), Authorize]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Where(p => p.Id == id).SingleOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok(product);
        }
    }
}
