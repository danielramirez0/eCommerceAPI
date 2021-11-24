﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerceStarterCode.Data;

namespace eCommerceStarterCode.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "c073f42c-79e8-41a6-a5d7-0ed41ae7aca0",
                            ConcurrencyStamp = "b957ca06-be2e-40a7-8e58-6f136f8bd5bc",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "a85197de-2346-492e-861e-08b0370b485f",
                            ConcurrencyStamp = "ab51f1aa-a6ff-4668-9ca9-9782c4b72f8a",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computers"
                        },
                        new
                        {
                            Id = 2,
                            Name = "TVs"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Appliances"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audio"
                        },
                        new
                        {
                            Id = 5,
                            Name = "CellPhones"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Cameras"
                        },
                        new
                        {
                            Id = 7,
                            Name = "MoviesAndMusic"
                        },
                        new
                        {
                            Id = 8,
                            Name = "SmartHome"
                        },
                        new
                        {
                            Id = 9,
                            Name = "SecurityAndWifi"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Games"
                        });
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 5,
                            Description = "Latest and greatest iPhone",
                            Name = "iPhone X",
                            Price = 999.99000000000001,
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Laptop i7, 16Gb Ram, 1TB SSD",
                            Name = "MacBook Pro",
                            Price = 1999.99,
                            Stock = 100
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Desktop i9, 32Gb RAM, 1TB SSD",
                            Name = "Alienware PC",
                            Price = 2999.9899999999998,
                            Stock = 100
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            Description = "Watch all  and greatest iPhone",
                            Name = "72\" Samsung OLED TV",
                            Price = 999.99000000000001,
                            Stock = 100
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 6,
                            Description = "20mp digital camera for content creators",
                            Name = "Sony Camera",
                            Price = 600.0,
                            Stock = 100
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "intelligent wifi washing maching- Know Your Laundry!!",
                            Name = "Smart Washer",
                            Price = 1500.0,
                            Stock = 5
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 10,
                            Description = "Own Space in this new sci-fi thriller FPS",
                            Name = "Space Men 5051",
                            Price = 60.0,
                            Stock = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "Monsterous gaming with 12GB GDDR6X RAM and Massive clock rates. Well worth the demand price created by miners!!",
                            Name = "Nvidi RTX 3080 Ti",
                            Price = 2300.0,
                            Stock = 100
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 10,
                            Description = "Router made for fueling your elctronics with precision wireless internet.",
                            Name = "TP-Link AC1750 Smart WiFi Router",
                            Price = 50.0,
                            Stock = 100
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            Description = "Latest and greatest iPhone XIII",
                            Name = "Iphone XIII",
                            Price = 1299.99,
                            Stock = 10
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 6,
                            Description = "Latest and greatest Camera",
                            Name = "Sharp Camera",
                            Price = 1500.99,
                            Stock = 100
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 1,
                            Description = "LMemory Stick",
                            Name = "Memory Stick",
                            Price = 1299.99,
                            Stock = 10
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 5,
                            Description = "Electronic Fan",
                            Name = "Electronic Fan",
                            Price = 299.99000000000001,
                            Stock = 100
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 10,
                            Description = "Wifi Receiver",
                            Name = "Wifi Receiver",
                            Price = 1299.99,
                            Stock = 110
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 4,
                            Description = "Iwatch",
                            Name = "Iwatch",
                            Price = 1299.99,
                            Stock = 10
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "Samsung Smart TV 75 in ",
                            Name = "Samsung Smart TV",
                            Price = 1299.99,
                            Stock = 10
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Home Theather 2022",
                            Name = "Home Theather",
                            Price = 959.99000000000001,
                            Stock = 100
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 1,
                            Description = "Compact Laptop 15 in Triple core Intel CPU",
                            Name = "Laptop",
                            Price = 1299.99,
                            Stock = 10
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 2,
                            Description = "Amazon Stick 350 TB Fully Cracked",
                            Name = "Amazon Stick",
                            Price = 599.99000000000001,
                            Stock = 100
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 1,
                            Description = "Computer 16 GB Ram Brand New ",
                            Name = "Computer 16 GB Ram",
                            Price = 129.99000000000001,
                            Stock = 10
                        });
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.ProductRating", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductRatings");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.SellerProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("SellerProducts");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("BillingAddressID")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShippingAddressID")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("BillingAddressID");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("ShippingAddressID");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceStarterCode.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.Order", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.OrderDetails", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceStarterCode.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.Product", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.ProductRating", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceStarterCode.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.SellerProduct", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceStarterCode.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.ShoppingCart", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceStarterCode.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.User", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.Address", "BillingAddress")
                        .WithMany()
                        .HasForeignKey("BillingAddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceStarterCode.Models.Address", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillingAddress");

                    b.Navigation("ShippingAddress");
                });
#pragma warning restore 612, 618
        }
    }
}
