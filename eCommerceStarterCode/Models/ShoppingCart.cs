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
        
        public int quantity { get; set; }

        [ForeignKey("Product")]

        public int ProductId { get; set; }

        public Product Product { get; set; }  
        
        [ForeignKey("User")]

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
