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
    [Route("api/[Controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
       
        [HttpGet("/orders"), Authorize]
        public IActionResult GetAllOrders()
        {
           
            var orders = _context.Orders.ToArray();
            
            if (orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
        }
       
       
        [HttpGet("orders/users/id"), Authorize]
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

        [HttpGet("orders/detail/id"), Authorize]
        public IActionResult GetOrderDetail(int id)
        {

            var orderDetail = _context.OrderDetails
                .Include(o => o.OrderId)
                .Where(o => o.OrderId == id)
                .Select(o => new { o.ProductId, o.Quantity, o.Price })
                .ToArray();

            if (orderDetail == null)
            {
                return NotFound();
            }
            return Ok(orderDetail);
        }

        [HttpGet("detail/{id}"), Authorize]
        public IActionResult GetOrderProduct(int id)
        {
           var productInOrder = _context.OrderDetails;

           var orders = from o in _context.OrderDetails
                         from p in _context.Products
                         where o.Order.Id == o.OrderId
                         where p.Id == id
                         select o;


            if (orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
        }

        [HttpGet("detail/{id}"), Authorize]
        public IActionResult GetOrderProduct(int id)
        {
           var productInOrder = _context.OrderDetails;

           var orders = from o in _context.OrderDetails
                         from p in _context.Products
                         where o.Order.Id == o.OrderId
                         where p.Id == id
                         select o;


            if (orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
        }

    }
}
