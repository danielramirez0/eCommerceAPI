using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        //[ForeignKey("PaymentId")]
        //public int PaymentId { get; set; }
        //public Payment Payment { get; set; }

        public DateTime Date { get; set; }
        public double Total { get; set; }  
        
    }
}