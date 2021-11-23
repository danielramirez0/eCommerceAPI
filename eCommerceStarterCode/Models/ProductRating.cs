using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Models
{
    [Keyless]
    public class ProductRating
    {
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public int Stars { get; set; }
        public string Review { get; set; }
    }
}
