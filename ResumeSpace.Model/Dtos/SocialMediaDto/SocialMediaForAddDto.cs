using ResumeSpace.Model.Rel;

namespace ResumeSpace.Model.SocialMediaDto;

public record SocialMediaForAddDto
{
    public Guid AppUserId { get; set; }
    public string Url { get; init; } = string.Empty;
    public int SocialMediaIconId { get; init; }
    public bool IsActive { get; init; } = true;
    public List<ResumesSocialMedias> ResumesSocialMedias { get; set; } = [];
}
