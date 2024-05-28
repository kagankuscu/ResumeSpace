namespace KaganKuscu.Model.Models
{
    public class Skill : BaseModel
    {
        public string Name { get; set; }
        public int Percent { get; set; }
        public Guid AppUserId { get; set; }
        public virtual ICollection<ResumeSkill> ResumesSkills { get; set; } = new List<ResumeSkill>(); 
    }
}
