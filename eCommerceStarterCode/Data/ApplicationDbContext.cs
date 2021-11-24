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
        public DbSet<ProductRating> ProductRatings { get; set; }
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

            modelBuilder.Entity<Category>()
                .HasData(
                new Category { Id = 1, Name = "Computers" },
                new Category { Id = 2, Name = "TVs" },
                new Category { Id = 3, Name = "Appliances" },
                new Category { Id = 4, Name = "Audio" },
                new Category { Id = 5, Name = "CellPhones" },
                new Category { Id = 6, Name = "Cameras" },
                new Category { Id = 7, Name = "MoviesAndMusic" },
                new Category { Id = 8, Name = "SmartHome" },
                new Category { Id = 9, Name = "SecurityAndWifi" },
                new Category { Id = 10, Name = "Games" }
                );

            modelBuilder.Entity<Product>()
                .HasData(
                new Product { Id = 1, Name = "iPhone X", Description = "Latest and greatest iPhone", Price = 999.99, Stock = 100, CategoryId = 5},
                new Product { Id = 2, Name = "MacBook Pro", Description = "Laptop i7, 16Gb Ram, 1TB SSD", Price = 1999.99, Stock = 100, CategoryId = 1},
                new Product { Id = 3, Name = "Alienware PC", Description = "Desktop i9, 32Gb RAM, 1TB SSD", Price = 2999.99, Stock = 100, CategoryId = 1},
                new Product { Id = 4, Name = "72\" Samsung OLED TV", Description = "Watch all  and greatest iPhone", Price = 999.99, Stock = 100, CategoryId = 5},
                new Product { Id = 5, Name = "Sony Camera", Description = "20mp digital camera for content creators", Price = 600, Stock = 100, CategoryId = 6},
                new Product { Id = 6, Name = "Smart Washer", Description = "intelligent wifi washing maching- Know Your Laundry!!", Price = 1500, Stock = 5, CategoryId = 3},
                new Product { Id = 7, Name = "Space Men 5051", Description = "Own Space in this new sci-fi thriller FPS", Price = 60, Stock = 200, CategoryId = 10},
                new Product { Id = 8, Name = "Nvidi RTX 3080 Ti", Description = "Monsterous gaming with 12GB GDDR6X RAM and Massive clock rates. Well worth the demand price created by miners!!", Price = 2300, Stock = 100, CategoryId = 1},
                new Product { Id = 9, Name = "TP-Link AC1750 Smart WiFi Router", Description = "Router made for fueling your elctronics with precision wireless internet.", Price = 50, Stock = 100, CategoryId = 10},
                new Product { Id = 10, Name = "Iphone XIII", Description = "Latest and greatest iPhone XIII", Price = 1299.99, Stock = 10, CategoryId = 5},
                new Product { Id = 11, Name = "Sharp Camera", Description = "Latest and greatest Camera", Price = 1500.99, Stock = 100, CategoryId = 6},
                new Product { Id = 12, Name = "Memory Stick", Description = "LMemory Stick", Price = 1299.99, Stock = 10, CategoryId = 1},
                new Product { Id = 13, Name = "Electronic Fan", Description = "Electronic Fan", Price = 299.99, Stock = 100, CategoryId = 5},
                new Product { Id = 14, Name = "Wifi Receiver", Description = "Wifi Receiver", Price = 1299.99, Stock = 110, CategoryId = 10},
                new Product { Id = 15, Name = "Iwatch", Description = "Iwatch", Price = 1299.99, Stock = 10, CategoryId = 4},
                new Product { Id = 16, Name = "Samsung Smart TV", Description = "Samsung Smart TV 75 in ", Price = 1299.99, Stock = 10, CategoryId = 2},
                new Product { Id = 17, Name = "Home Theather", Description = "Home Theather 2022", Price = 959.99, Stock = 100, CategoryId = 2},
                new Product { Id = 18, Name = "Laptop", Description = "Compact Laptop 15 in Triple core Intel CPU", Price = 1299.99, Stock = 10, CategoryId = 1},
                new Product { Id = 19, Name = "Amazon Stick", Description = "Amazon Stick 350 TB Fully Cracked", Price = 599.99, Stock = 100, CategoryId = 2},
                new Product { Id = 20, Name = "Computer 16 GB Ram", Description = "Computer 16 GB Ram Brand New ", Price = 129.99, Stock = 10, CategoryId = 1}
                );


        }

    }
}