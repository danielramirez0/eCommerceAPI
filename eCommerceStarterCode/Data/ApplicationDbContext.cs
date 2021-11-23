using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductRating> ProductRatings  { get; set; }
        public DbSet<SellerProduct> SellerProducts { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());

        }

    }
}
