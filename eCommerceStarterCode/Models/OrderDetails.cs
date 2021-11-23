using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    [Keyless]
    public class OrderDetails
    {
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order{ get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }   
        public int Quantity { get; set; }

    }
}
