using KaganKuscu.Model.Models;
using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.SocialMediaDto;

public record SocialMediaForUpdateDto
{
    public Guid Guid { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Url { get; init; } = string.Empty;
    public SocialMediaIcon? SocialMediaIcon { get; init; }
    public bool IsActive { get; init; }
    public List<ResumesSocialMedias> ResumesSocialMedias { get; set; } = [];
}
