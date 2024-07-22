using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.Dtos.SkillsDto
{
    public record SkillForAddDto
    {
        public Guid AppUserId { get; set; } 
        public string Name { get; init; } = string.Empty; 
        public int Percent { get; init; }
        public bool IsActive { get; set; }
        public ICollection<ResumeSkill> ResumesSkills { get; set; } = [];
    }
}
