using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.Dtos.WorkExperienceDto
{
    public record WorkExperienceForUpdateDto    
    {
      public Guid Guid { get; init; }
      public string Name { get; init; } = string.Empty;
      public string StartDate { get; init; } = string.Empty;
      public string EndDate { get; init; } = "01/01/0001"; 
      public string Description { get; init; } = string.Empty;
      public string Role { get; init; } = string.Empty;
      public bool IsActive { get; init; }
      public List<ResumesWorkExperiences> ResumesWorkExperiences { get; set; } = [];
    }
}
