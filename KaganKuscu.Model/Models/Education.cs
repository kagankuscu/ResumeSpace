using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.Models
{
    public class Education : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Role { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid AppUserId { get; set; }
        public virtual ICollection<ResumesEducations> ResumesEducations { get; set; } = [];
    }
}
