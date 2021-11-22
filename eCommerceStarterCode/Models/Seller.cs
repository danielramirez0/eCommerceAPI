using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.Models
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}