using KaganKuscu.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaganKuscu.DataAccess.Config
{
  public class ResumeSkillConfig : IEntityTypeConfiguration<ResumeSkill>
  {
    public void Configure(EntityTypeBuilder<ResumeSkill> builder)
    {
      builder.HasData
        (
         new ResumeSkill
         {
         ResumeId = 1,
         SkillId = 1,
         },
         new ResumeSkill
         {
         ResumeId = 1,
         SkillId = 2,
         },
         new ResumeSkill
         {
         ResumeId = 1,
         SkillId = 3,
         },
         new ResumeSkill
         {
         ResumeId = 1,
         SkillId = 4,
         },
         new ResumeSkill
         {
           ResumeId = 1,
           SkillId = 5,
         }
         );
    }
  }
}
