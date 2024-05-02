using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaganKuscu.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaganKuscu.DataAccess.Config
{
    public class SkillConfig : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasData(
                new Skill { Id = 1, PersonId = 1, Name = "Asp.Net Core", Percent = 80 },
                new Skill { Id = 2, PersonId = 1, Name = "C#", Percent = 75 },
                new Skill { Id = 3, PersonId = 1, Name = "Javascript", Percent = 60 },
                new Skill { Id = 4, PersonId = 1, Name = "MS SQL", Percent = 72 },
                new Skill { Id = 5, PersonId = 1, Name = "HTML & CSS", Percent = 82 }
            );
        }
    }
}