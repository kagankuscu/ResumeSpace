using ResumeSpace.Model.Models;

namespace ResumeSpace.Model.Rel
{
    public class ResumesSocialMedias
    {
        public int ResumeId { get; set; }        
        public virtual Resume? Resume { get; set; }

        public int SocialMediaId { get; set; }
        public SocialMedia? SocialMedia { get; set; }
    }
}