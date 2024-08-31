using ResumeSpace.Model.Rel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeSpace.DataAccess.Config
{
  public class ResumeSkillConfig : IEntityTypeConfiguration<ResumeSkill>
  {
    public void Configure(EntityTypeBuilder<ResumeSkill> builder)
    {
      builder.HasData
        (
          new ResumeSkill { ResumeId = 1, SkillId = 1 },
          new ResumeSkill { ResumeId = 1, SkillId = 2 },
          new ResumeSkill { ResumeId = 1, SkillId = 3 },
          new ResumeSkill { ResumeId = 1, SkillId = 4 },
          new ResumeSkill { ResumeId = 1, SkillId = 5 },
          new ResumeSkill { ResumeId = 1, SkillId = 6 }
        );
    }
  }
}
