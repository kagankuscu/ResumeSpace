using KaganKuscu.Model.Dtos.ResumesDto;

namespace KaganKuscu.Model.SocialMediaDto;

public record SocialMediaForGetWithResumesDto
{
    public Guid Guid { get; init; }
    public string Url { get; init; } = string.Empty;
    public SocialMediaIconForGetDto? SocialMediaIcon { get; set; }
    public bool IsActive { get; init; }
    public List<ResumeForGetDto> Resumes { get; set; } = [];
}
