using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace eCommerceStarterCode.Models
{
    [Keyless]
    public class SellerProduct
    {
      
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("ProductId")]
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
