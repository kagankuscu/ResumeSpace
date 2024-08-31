using ResumeSpace.Model.Models;

namespace ResumeSpace.Model.Rel
{
  public record ResumesEducations
  {
    public int ResumeId { get; set; }
    public Resume? Resume { get; set; }

    public int EducationId { get; set; }
    public Education? Education { get; set; }
  }
}
