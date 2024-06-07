using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.SocialMediaDto;

public record SocialMediaForAddDto
{
    public Guid AppUserId { get; set; }
    public string? Name { get; init; }
    public string Url { get; init; } = string.Empty;
    public string IconCssClass { get; init; } = string.Empty;
    public bool IsActive { get; init; }
    public List<ResumesSocialMedias> ResumesSocialMedias { get; set; } = [];
}
