using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace eCommerceStarterCode.Models

{
    [Keyless]
    public partial class UserAddress
    {

        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }

        public virtual User User { get; set; }
        public virtual Address Address { get; set; }
    }
}
