using ResumeSpace.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeSpace.DataAccess.Config
{
    public class SocialMediaIconConfig : IEntityTypeConfiguration<SocialMediaIcon>
    {
        public void Configure(EntityTypeBuilder<SocialMediaIcon> builder)
        {
            builder.HasData(
                new SocialMediaIcon { Id = 1, Name = "Github", CssClass = "rsicon rsicon-github" },
                new SocialMediaIcon { Id = 2, Name = "LinkedIn", CssClass = "rsicon rsicon-linkedin" },
                new SocialMediaIcon { Id = 3, Name = "Instagram", CssClass = "rsicon rsicon-instagram" },
                new SocialMediaIcon { Id = 4, Name = "Facebook", CssClass = "rsicon rsicon-facebook" },
                new SocialMediaIcon { Id = 5, Name = "Youtube", CssClass = "rsicon rsicon-youtube" },
                new SocialMediaIcon { Id = 6, Name = "X (Twitter)", CssClass = "rsicon rsicon-twitter" },
                new SocialMediaIcon { Id = 7, Name = "Slack", CssClass = "rsicon rsicon-slack" },
                new SocialMediaIcon { Id = 8, Name = "Reddit", CssClass = "rsicon rsicon-reddit" }
            );
        }
    }
}