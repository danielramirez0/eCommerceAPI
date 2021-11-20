using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public int name { get; set; }
        public int street { get; set; }
        public int city { get; set; }
        public int zip { get; set; }
        public int type { get; set; }

        [ForeignKey("User")]
        public string UserID { get; set; }  
        public User User { get; set; }
    }
}
