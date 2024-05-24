namespace KaganKuscu.Model.Dtos.Skills
{
    public record SkillForAddDto
    {
        public Guid AppUserId { get; set; } 
        public string Name { get; init; } = string.Empty; 
        public int Percent { get; init; }
        public ICollection<int> Resumes { get; init; } = [];
    }
}