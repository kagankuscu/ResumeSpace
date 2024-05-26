namespace KaganKuscu.Model.Models
{
  public class ResumeSkill : BaseModel
  {
    public int ResumeId { get; set; }
    public Resume? Resume { get; set; }

    public int SkillId { get; set; }
    public Skill? Skill { get; set; }
  }
}
