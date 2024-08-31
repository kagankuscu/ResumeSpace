using ResumeSpace.Model.Rel;

namespace ResumeSpace.Model.Dtos.ReferenceDto
{
  public record ReferenceForAddDto
  {
    public Guid AppUserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string Quote { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string ImagePath { get; set; } = "/img/rs-avatar-64x64.jpg";
    public bool IsActive { get; init; }
    public List<ResumesReferences> ResumesReferences { get; set; } = [];
  }
}
