using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using eCommerceStarterCode.Models;
using System;

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
            //if (User.IsInRole("Seller"))
            //{
            var orders = _context.Orders.ToArray();

            if (orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
            //}
            //else
            //{
            //return Unauthorized(User);
            //}
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
            var orderDetail = _context.OrderDetails.Where(o => o.OrderId == id).Include(o => o.Order).Include(o=>o.Product).ToList();
            if (orderDetail == null)
            {
                return NotFound();
            }
            return Ok(orderDetail);
        }

        [HttpGet("product/{id}"), Authorize]
        public IActionResult GetOrdersByProduct(int id)
        {
            var productOrders = _context.OrderDetails.Where(od => od.ProductId == id).Include(od => od.Product);

            if (productOrders == null)
            {
                return NotFound();
            }
            return Ok(productOrders);
        }

        [HttpPost, Authorize]
        public IActionResult SubmitOrder([FromBody] Order order)
        {
            var userId = User.FindFirstValue("id");
            order.UserId = userId;
            order.Date = DateTime.Now;

            _context.Orders.Add(order);
            _context.SaveChanges();

            return Ok(order);

        }

        [HttpPost("detail"), Authorize]
        public IActionResult SaveOrderDetails([FromBody] OrderDetails details)
        {
            var originalOrder = _context.Orders.Where(o => o.Id == details.OrderId).SingleOrDefault();
            if (originalOrder != null)
            {

                var newOrder = new OrderDetails()
                {
                    OrderId = originalOrder.Id,
                    ProductId = details.ProductId,
                    Price = details.Price,
                    Quantity = details.Quantity,
                };
                _context.OrderDetails.Add(newOrder);
                _context.SaveChanges();

                return Ok(details);
            }else
            {
                return BadRequest();
            }

        }

    }
}
