using KaganKuscu.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaganKuscu.DataAccess.Config
{
    public class SocialMediaConfig : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.HasData(
                new SocialMedia { Id = 1, AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0"), Name = "Github", Url = "https://github.com/kagankuscu", SocialMediaIconId = 1 },
                new SocialMedia { Id = 2, AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0"), Name = "LinkedIn", Url = "https://www.linkedin.com/in/kagan-kuscu/", SocialMediaIconId = 2 },
                new SocialMedia { Id = 3, AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0"), Name = "Instagram", Url = "https://www.instagram.com/kagan_kuscu/", SocialMediaIconId = 3 }
            );
        }
    }
}