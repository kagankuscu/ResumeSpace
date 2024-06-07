using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;

namespace KaganKuscu.Model.SocialMediaDto;

public record SocialMediaForGetWithResumesDto
{
    public Guid Guid { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Url { get; init; } = string.Empty;
    public SocialMediaIcon? SocialMediaIcon { get; init; }
    public bool IsActive { get; init; }
    public List<ResumeForGetDto> Resumes { get; set; } = [];
}
