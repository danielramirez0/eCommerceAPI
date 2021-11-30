using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
     
        [HttpGet("all")]
        public IActionResult GetAllCategories()
        {

            var categories = _context.Categories;
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _context.Categories.Where(c => c.Id == id).SingleOrDefault();
            if(category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpGet("name/{name}")]
        public IActionResult GetCategoryById(string name)
        {
            var category = _context.Categories.Where(c => c.Name == name).SingleOrDefault();
            if(category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
    }
}
