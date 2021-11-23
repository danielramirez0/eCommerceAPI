using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    [Keyless]
    public class ShoppingCart
    {
        
        public int Quantity { get; set; }

        [ForeignKey("Product")]

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }  
        
        [ForeignKey("User")]

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
