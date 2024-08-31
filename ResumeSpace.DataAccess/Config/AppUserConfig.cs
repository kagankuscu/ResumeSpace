using ResumeSpace.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ResumeSpace.DataAccess.Config
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();
            
            builder.HasData(
                new AppUser
                {
                    Id = "bf6215ac-ffd1-4f8b-894e-8b9ab32e66c4",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null!, "Admin123."),
                },
                new AppUser
                {
                    Id = "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                    UserName = "kagankuscu",
                    NormalizedUserName = "KAGANKUSCU",
                    Email = "kuscukagan@gmail.com",
                    NormalizedEmail = "KUSCUKAGAN@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null!, "KaganKuscu96."),
                }
            );
        }
    }
}
