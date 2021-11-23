using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("ShippingAddress")]
        public int ShippingAddressID { get; set; }  
        public Address ShippingAddress { get; set; }

        [ForeignKey("BillingAddress")]
        public int BillingAddressID { get; set; }  
        public Address BillingAddress { get; set; }

    }
}
