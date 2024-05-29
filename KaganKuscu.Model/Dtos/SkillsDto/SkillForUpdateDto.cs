using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.Dtos.SkillsDto
{
    public record SkillForUpdateDto
    {
       public Guid Guid { get; init; }
       public string Name { get; init; } = string.Empty; 
       public int Percent { get; init; }
       public ICollection<ResumeSkill> ResumesSkills { get; set; } = [];
    }
}
