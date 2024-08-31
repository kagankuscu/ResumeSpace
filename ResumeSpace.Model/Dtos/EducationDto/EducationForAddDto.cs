using ResumeSpace.Model.Rel;

namespace ResumeSpace.Model.Dtos.EducationDto
{
    public record EducationForAddDto 
    {
        public Guid AppUserId { get; set; }
        public string Name { get; init; } = string.Empty;
        public string StartDate { get; init; } = string.Empty;
        public string? EndDate { get; init; } = "01/01/0001";
        public string Role { get; init; } = string.Empty;
        public virtual ICollection<ResumesEducations> ResumesEducations { get; set; } = [];

    }
}
