using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.SocialMediaDto;

public record SocialMediaForUpdateDto
{
    public Guid Guid { get; init; }
    public string Url { get; init; } = string.Empty;
    public int SocialMediaIconId { get; init; }
    public bool IsActive { get; init; }
    public List<ResumesSocialMedias> ResumesSocialMedias { get; set; } = [];
}
