using ResumeSpace.Model.Rel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeSpace.DataAccess.Config
{
  public class ResumesEducationsConfig : IEntityTypeConfiguration<ResumesEducations>
  {
    public void Configure(EntityTypeBuilder<ResumesEducations> builder)
    {
      builder.HasData
        (
         new ResumesEducations { ResumeId = 1, EducationId = 1 },
         new ResumesEducations { ResumeId = 1, EducationId = 2 },
         new ResumesEducations { ResumeId = 1, EducationId = 3 },
         new ResumesEducations { ResumeId = 1, EducationId = 4 },
         new ResumesEducations { ResumeId = 1, EducationId = 5 }
        );
    }
  }
}