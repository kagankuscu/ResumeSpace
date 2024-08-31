using ResumeSpace.Model.Rel;

namespace ResumeSpace.Model.Models
{
    public class WorkExperience : BaseModel
    {
        public Guid AppUserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Role { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public virtual ICollection<ResumesWorkExperiences> ResumesWorkExperiences { get; set; } = [];

    }
}
