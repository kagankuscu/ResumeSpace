using ResumeSpace.Model.Rel;

namespace ResumeSpace.Model.Dtos.WorkExperienceDto
{
    public record WorkExperienceForAddDto
    {
        public Guid AppUserId { get; set; }        public string Name { get; init; } = string.Empty;
        public string StartDate { get; init; } = string.Empty;
        public string EndDate { get; init; } = "01/01/0001";
        public string Role { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public List<ResumesWorkExperiences> ResumesWorkExperiences { get; init; } = [];
    }
}
