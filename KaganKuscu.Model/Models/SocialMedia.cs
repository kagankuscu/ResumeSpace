using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.Models
{
    public class SocialMedia : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string IconCssClass { get; set; } = string.Empty;

        public Guid AppUserId { get; set; }
        public virtual ICollection<ResumesSocialMedias> ResumesSocialMedias { get; set; } = [];
    }
}