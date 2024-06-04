using KaganKuscu.Model.Dtos.ResumesDto;

namespace KaganKuscu.Model.Dtos.ReferenceDto
{
  public record ReferenceForGetWithResumesDto
  {
    public Guid Guid { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string Quote { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public List<ResumeForGetDto> Resumes { get; set; } = [];
  }
}
