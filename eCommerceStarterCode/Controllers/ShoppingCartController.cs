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
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet, Authorize]
        public IActionResult GetShoppingCart()
        {
            var userId = User.FindFirstValue("id");
            var shoppingCart = _context.ShoppingCart.Where(pu => pu.UserId == userId).Include(pu => pu.Product).Include(pu => pu.User);
            if (shoppingCart == null)
            {
                return NotFound();
            }
            return Ok(shoppingCart);
        }

        [HttpPost, Authorize]

        public IActionResult PostShoppingCartItem([FromBody] string productId, int quantity)
        {
            var userId = User.FindFirstValue("id");
            var selectedItem = productId;
            var existingShoppingCartItem = _context.ShoppingCart.Where(ci => ci.ProductId == selectedItem && ci.UserId == userId).SingleOrDefault();
            if (existingShoppingCartItem != null)
            {
                existingShoppingCartItem.Quantity++;
                _context.ShoppingCart.Update(existingShoppingCartItem);
                _context.SaveChanges();
            }
            else
            {
                var newShoppingCartItem = new ShoppingCart()
                {
                    UserId = userId,
                    ProductId = selectedItem,
                    Quantity = 1,
                };

                _context.ShoppingCart.Add(newShoppingCartItem);
                _context.SaveChanges();
            }
        }
    }
}
