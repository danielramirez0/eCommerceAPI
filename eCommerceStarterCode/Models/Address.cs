using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string type { get; set; }

        [ForeignKey("User")]
        public string UserID { get; set; }  
        public User User { get; set; }
    }
}
