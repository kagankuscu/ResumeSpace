using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.Dtos.EducationDto
{
    public record EducationForUpdateDto
    {
      public Guid Guid { get; init; }
      public string Name { get; init; } = string.Empty;
      public string StartDate { get; init; } = string.Empty;
      public string EndDate { get; init; } = "01/01/0001"; 
      public string Role { get; init; } = string.Empty;
      public bool IsActive { get; init; }
      public List<ResumesEducations> ResumesEducations { get; set; } = [];
    }
}
