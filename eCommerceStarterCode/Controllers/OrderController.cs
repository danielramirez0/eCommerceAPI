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

        [HttpGet("all"), Authorize]
        public IActionResult GetAllOrders()
        {
            if (User.IsInRole("Seller"))
            {
                var orders = _context.Orders.ToArray();

                if (orders == null)
                {
                    return NotFound();
                }
                return Ok(orders);
            }
            else
            {
                return Unauthorized(User);
            }
        }


        [HttpGet("user"), Authorize]
        public IActionResult GetAllOrdersForUser()
        {
            var userId = User.FindFirstValue("id");
            var orders = _context.Orders.Where(o => o.UserId == userId);

            if (orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
        }

        [HttpGet("detail/{id}"), Authorize]
        public IActionResult GetOrderDetail(int id)
        {
            var orderDetail = _context.OrderDetails.Where(o => o.OrderId == id).Include(o => o.Order).SingleOrDefault();
            if (orderDetail == null)
            {
                return NotFound();
            }
            return Ok(orderDetail);
        }

    }
}
