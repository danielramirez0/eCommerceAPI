using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerceStarterCode.Configuration
{
    public class RolesConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
            (
                new IdentityRole
                {
                    Id = "c073f42c-79e8-41a6-a5d7-0ed41ae7aca0",
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Id = "a85197de-2346-492e-861e-08b0370b485f",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );
        }
    }
}
