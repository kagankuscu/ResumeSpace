using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.Dtos.ReferenceDto
{
  public record ReferenceForAddDto
  {
    public Guid AppUserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string Quote { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public bool IsActive { get; init; }
    public List<ResumesReferences> ResumesReferences { get; set; } = [];
  }
}
