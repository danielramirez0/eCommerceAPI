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
            var shoppingCart = _context.ShoppingCarts.Where(pu => pu.UserId == userId).Include(pu => pu.Product).Include(pu => pu.User);
            if (shoppingCart == null)
            {
                return NotFound();
            }
            return Ok(shoppingCart);
        }

        [HttpPost, Authorize]

        public IActionResult PostShoppingCartItem([FromBody] Product product, [FromQuery] int quantity)
        {
            var userId = User.FindFirstValue("id");
            var newShoppingCartItem = new ShoppingCart()
            {
                UserId = userId,
                ProductId = product.Id,
                Quantity = quantity,
            };

            _context.ShoppingCarts.Add(newShoppingCartItem);
            _context.SaveChanges();
            return Ok(newShoppingCartItem);
        }

        [HttpPut, Authorize]
        public IActionResult UpdateShopppingCart([FromBody] Product product, [FromQuery] int quantity)
        {
            var userId = User.FindFirstValue("id");
            var updateItem = _context.ShoppingCarts.Where(ci => ci.ProductId == product.Id && ci.UserId == userId).SingleOrDefault();
            updateItem.Quantity = quantity;
            _context.ShoppingCarts.Update(updateItem);
            _context.SaveChanges();

            var updatedCart = _context.ShoppingCarts.Where(pu => pu.UserId == userId).Include(pu => pu.Product).Include(pu => pu.User);
            return Ok(updatedCart);
        }

        [HttpDelete, Authorize]
        public IActionResult DeleteItemFromShoppigCart([FromBody] Product product)
        {
            var userId = User.FindFirstValue("id");
            var item = _context.ShoppingCarts.Where(ci => ci.ProductId == product.Id && ci.UserId == userId).SingleOrDefault();
            _context.ShoppingCarts.Remove(item);
            _context.SaveChanges();

            var updatedCart = _context.ShoppingCarts.Where(pu => pu.UserId == userId).Include(pu => pu.Product).Include(pu => pu.User);
            return Ok(updatedCart);
        }
    }
}
