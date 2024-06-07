using KaganKuscu.Model.Models;

namespace KaganKuscu.Model.Rel
{
    public class ResumesSocialMedias
    {
        public int ResumeId { get; set; }        
        public virtual Resume? Resume { get; set; }

        public int SocialMediaId { get; set; }
        public SocialMedia? SocialMedia { get; set; }
    }
}