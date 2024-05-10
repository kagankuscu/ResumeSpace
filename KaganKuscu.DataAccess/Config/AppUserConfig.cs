using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.DataAccess.Config
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();
            
            builder.HasData(new AppUser
            {
                Id = "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                UserName = "kagankuscu",
                NormalizedUserName = "KAGANKUSCU",
                Email = "kuscukagan@gmail.com",
                NormalizedEmail = "KUSCUKAGAN@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "KaganKuscu96."),
            });
        }
    }
}