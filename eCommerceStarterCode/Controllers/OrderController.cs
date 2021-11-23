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
    [Route("api/orders/all")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
       
        [HttpGet, Authorize]
        public IActionResult GetAllOrders()
        {
            //var userId = User.FindFirstValue("id");
            var orders = _context.Orders.ToArray();
            
            if (orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
        }
        [HttpGet("{id:int}"), Authorize]
        public IActionResult GetSingleOrder(int id)
        {
            var userId = User.FindFirstValue("id");
            var orders = _context.Orders.Where(o => o.UserId == userId).ToArray();

            if (orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
        }
    }
}
