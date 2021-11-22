using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace eCommerceStarterCode.Models
{
    [Keyless]
    public class SellerProduct
    {
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        [ForeignKey("ProductId")]
        public string ProductId { get; set; }
    }
}
