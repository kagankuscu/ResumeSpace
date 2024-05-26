namespace KaganKuscu.Model.Models
{
    public class WorkExperience : BaseModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public int ResumeId { get; set; }

    }
}