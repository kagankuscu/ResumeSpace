using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaganKuscu.DataAccess.Config
{
    public class RoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole 
                {
                    Id = "A34A825F-E1A6-427C-8194-0D051C22560F",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "40A649CC-F41A-4505-94B6-7335F12E3A5D",
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
        }
    }
}