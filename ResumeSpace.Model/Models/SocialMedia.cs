using ResumeSpace.Model.Rel;

namespace ResumeSpace.Model.Models
{
    public class SocialMedia : BaseModel
    {
        public string Url { get; set; } = string.Empty;
        public int SocialMediaIconId { get; set; }

        public Guid AppUserId { get; set; }
        public virtual ICollection<ResumesSocialMedias> ResumesSocialMedias { get; set; } = [];
        public virtual SocialMediaIcon? SocialMediaIcon { get; set; }
    }
}