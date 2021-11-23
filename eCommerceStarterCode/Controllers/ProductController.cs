using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using eCommerceStarterCode.Models;
using eCommerceStarterCode.Extensions;
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
        
        // <baseurl>/api/examples/user
        [HttpGet]

        public IActionResult GetAllProducts()
        {
            var products = _context.Products;
            if(products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }
        [HttpGet("{search}")]
        public IActionResult GetProductByName([FromQuery] string type, string value)
        {

            var products = _context.Products;
            if (products == null)
            {
                return NotFound();
            }

                var product = _context.Products.Where(p => p.GetProperty(type) == value).SingleOrDefault();
            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);

        }
        
        public IActionResult PostProduct([FromBody]Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);

        }

        public IActionResult DeleteProduct([FromBody]Product ProductId)
        {
            _context.Products.Remove(ProductId);
            _context.SaveChanges();
            return StatusCode(201, ProductId);

        }
    }
}
