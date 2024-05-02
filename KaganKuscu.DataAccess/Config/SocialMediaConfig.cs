using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                new SocialMedia { Id = 1, PersonId = 1, Name = "Github", Url = "https://github.com/kagankuscu", IconCssClass = "rsicon rsicon-github" },
                new SocialMedia { Id = 2, PersonId = 1, Name = "LinkedIn", Url = "https://www.linkedin.com/in/kagan-kuscu/", IconCssClass = "rsicon rsicon-linkedin" },
                new SocialMedia { Id = 3, PersonId = 1, Name = "Instagram", Url = "https://www.instagram.com/kagan_kuscu/", IconCssClass = "rsicon rsicon-instagram" }
            );
        }
    }
}