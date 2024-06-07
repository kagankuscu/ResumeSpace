using KaganKuscu.Model.Rel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaganKuscu.DataAccess.Config
{
    public class ResumesSocialMediaConfig : IEntityTypeConfiguration<ResumesSocialMedias>
    {
        public void Configure(EntityTypeBuilder<ResumesSocialMedias> builder)
        {
            builder.HasData(
                new ResumesSocialMedias { ResumeId = 1, SocialMediaId = 1 },
                new ResumesSocialMedias { ResumeId = 1, SocialMediaId = 2 },
                new ResumesSocialMedias { ResumeId = 1, SocialMediaId = 3 }
            );
        }
    }
}