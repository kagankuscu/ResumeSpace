using ResumeSpace.Model.Models;

namespace ResumeSpace.Model.Rel
{
  public class ResumeSkill
  {
    public int ResumeId { get; set; }
    public Resume? Resume { get; set; }

    public int SkillId { get; set; }
    public Skill? Skill { get; set; }
  }
}
