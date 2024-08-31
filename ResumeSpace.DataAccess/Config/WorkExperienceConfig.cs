using ResumeSpace.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeSpace.DataAccess.Config
{
    public class WorkExperienceConfig : IEntityTypeConfiguration<WorkExperience>
    {
        public void Configure(EntityTypeBuilder<WorkExperience> builder)
        {
            builder.HasData(
                new WorkExperience {
                    Id = 1,
                    AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0"),
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
