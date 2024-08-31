using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResumeSpace.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeSpace.DataAccess.Config
{
    public class SkillConfig : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasData(
                new Skill { Id = 1, Name = "Asp.Net Core", Percent = 80, AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0") },
                new Skill { Id = 2, Name = "C#", Percent = 75, AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0") },
                new Skill { Id = 3, Name = "Javascript", Percent = 60, AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0") },
                new Skill { Id = 4, Name = "MS SQL", Percent = 72, AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0") },
                new Skill { Id = 5, Name = "HTML & CSS", Percent = 82, AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0") }
            );
        }
    }
}