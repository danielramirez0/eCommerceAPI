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
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        // <baseurl>/api/examples/user
        [HttpGet]
        public IActionResult GetProduct()
        {
            var products = _context.Products;
            if (products == null)
            {
                return NotFound();
            }

            else
            {
                return Ok(products);
            }
        }
        
        public IActionResult PostProduct([FromBody]Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);

        }

        public IActionResult DeleteProduct([FromBody]Product value)
        {
            _context.Products.Remove(value);
            _context.SaveChanges();
            return StatusCode(201, value);

        }
    }
}
