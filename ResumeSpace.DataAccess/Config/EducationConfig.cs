using ResumeSpace.Model.Models;
using ResumeSpace.Model.Rel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeSpace.DataAccess.Config
{
    public class EducationConfig : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasData(
                new Education {
                    Id = 1,
                    Name = "IZMIT VOCATIONAL AND TECHNICAL ANATOLIAN HIGH SCHOOL",
                    StartDate = new DateTime(2012, 9, 17),
                    EndDate = new DateTime(2015, 6, 12),
                    Role = "Electrical Technician",
                    Description = "",
                    AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0"),
                },
                new Education {
                    Id = 2,
                    Name = "KOCAELI UNIVERSITY HEREKE VOCATIONAL SCHOOL",
                    StartDate = new DateTime(2015, 9, 14),
                    EndDate = new DateTime(2017, 6, 10),
                    Role = "Electrical Engineer",
                    Description = "",
                    AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0"),
                },
                new Education {
                    Id = 3,
                    Name = "SOFIA TECHNICAL UNIVERSITY",
                    StartDate = new DateTime(2017, 9, 26),
                    EndDate = new DateTime(2021, 6, 24),
                    Role = "Mechatronics Engineer",
                    Description = "",
                    AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0"),
                },
                new Education {
                    Id = 4,
                    Name = "SOFIA TECHNICAL UNIVERSITY",
                    StartDate = new DateTime(2021, 11, 3),
                    EndDate = new DateTime(2023, 6, 23),
                    Role = "Master's in Mechatronics Engineering",
                    Description = "",
                    AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0"),
                },
                new Education {
                    Id = 5,
                    Name = "ACUNMEDYA ACADEMY",
                    StartDate = new DateTime(2023, 9, 11),
                    EndDate = new DateTime(0001, 1, 1),
                    Role = ".Net Core Backend Developer",
                    Description = "",
                    AppUserId = Guid.Parse("D0C23476-68D0-4DA0-AAD4-3ADAE20702C0"),
                }
            );
        }
    }
}
