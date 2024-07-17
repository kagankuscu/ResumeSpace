using KaganKuscu.Model.Dtos.ResumesDto;

namespace KaganKuscu.Model.Dtos.SkillsDto;

public record SkillForGetWithResumesDto
{
    public Guid Guid { get; init; }
    public string Name { get; init; } = string.Empty;
    public int Percent { get; init; }
    public bool IsActive { get; init; }
    public ICollection<ResumeForGetDto> Resumes { get; set; } = [];
}
