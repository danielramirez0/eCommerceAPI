using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.Models
{
    public class ProductRating
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public int Stars { get; set; }
        public string Review { get; set; }
    }
}
