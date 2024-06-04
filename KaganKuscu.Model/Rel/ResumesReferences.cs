using KaganKuscu.Model.Models;

namespace KaganKuscu.Model.Rel
{
  public record ResumesReferences
  {
    public int ResumeId { get; set; }
    public Resume? Resume { get; set; }

    public int ReferenceId { get; set; }
    public Reference? Reference { get; set; }
  }
}
