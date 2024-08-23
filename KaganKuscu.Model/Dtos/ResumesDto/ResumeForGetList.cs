namespace KaganKuscu.Model.Dtos.ResumesDto
{
    public class ResumeForGetList
    {
        public string UserName { get; set; } = string.Empty;
        public string? FullName { get; set; }
        public string Title { get; set; } = string.Empty;
        public string About { get; set; } = string.Empty;
    }
}