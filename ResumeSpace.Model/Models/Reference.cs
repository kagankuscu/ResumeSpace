using ResumeSpace.Model.Rel;

namespace ResumeSpace.Model.Models
{
    public class Reference : BaseModel
    {
        public Guid AppUserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string Quote { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public List<ResumesReferences> ResumesReferences { get; set; } = [];
    }
}
