using KaganKuscu.Model.Models;

namespace KaganKuscu.Model.Rel
{
  public record ResumesWorkExperiences  {
    public int ResumeId { get; set; }
    public Resume? Resume { get; set; }

    public int WorkExperienceId { get; set; }
    public WorkExperience? WorkExperience { get; set; }
  }
}
