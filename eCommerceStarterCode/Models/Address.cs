//using System;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//#nullable disable

namespace eCommerceStarterCode.Models
{
    public partial class Address
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string type { get; set; }
    }
}
