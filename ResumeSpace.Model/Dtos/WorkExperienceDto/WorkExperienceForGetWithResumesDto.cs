using ResumeSpace.Model.Dtos.ResumesDto;

namespace ResumeSpace.Model.Dtos.WorkExperienceDto
{
    public record WorkExperienceForGetWithResumesDto    
    {
      public Guid Guid { get; init; }
      public string Name { get; init; } = string.Empty;
      public DateTime StartDate { get; init; }
      public DateTime EndDate { get; init; }
      public string Description { get; init; } = string.Empty;
      public string Role { get; init; } = string.Empty;
      public bool IsActive { get; init; }
      public List<ResumeForGetDto> Resumes { get; set; } = [];
    }
}
