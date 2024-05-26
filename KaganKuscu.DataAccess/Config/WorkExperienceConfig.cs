using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaganKuscu.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaganKuscu.DataAccess.Config
{
    public class WorkExperienceConfig : IEntityTypeConfiguration<WorkExperience>
    {
        public void Configure(EntityTypeBuilder<WorkExperience> builder)
        {
            builder.HasData(
                new WorkExperience {
                    Id = 1,
                    ResumeId = 1,
                    Name = "Deadline Bilişim",
                    StartDate = new DateTime(2023, 12, 25),
                    EndDate = new DateTime(0001, 1, 1),
                    Role = ".Net Backend Developer",
                    Description = ".Net Backend Developer"
                }
            );
        }
    }
}