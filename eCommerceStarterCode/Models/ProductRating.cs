using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
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
