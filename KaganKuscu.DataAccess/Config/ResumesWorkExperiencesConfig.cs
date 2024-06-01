using KaganKuscu.Model.Rel;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.DataAccess.Config
{
    public class ResumesWorkExperiencesConfig : IEntityTypeConfiguration<ResumesWorkExperiences>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ResumesWorkExperiences> builder)
        {
          builder.HasData(new ResumesWorkExperiences { ResumeId = 1, WorkExperienceId = 1 });
        }
    }
}
