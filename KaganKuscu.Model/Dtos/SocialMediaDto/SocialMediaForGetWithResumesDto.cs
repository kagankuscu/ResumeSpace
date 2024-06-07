using KaganKuscu.Model.Dtos.ResumesDto;

namespace KaganKuscu.Model.SocialMediaDto;

public record SocialMediaForGetWithResumesDto
{
    public Guid Guid { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Url { get; init; } = string.Empty;
    public string IconCssClass { get; init; } = string.Empty;
    public bool IsActive { get; init; }
    public List<ResumeForGetDto> ResumesSocialMedias { get; set; } = [];
}
