namespace ResumeSpace.Model.SocialMediaDto;

public record SocialMediaForGetDto
{
    public Guid Guid { get; set; }
    public string Url { get; set; } = string.Empty;
    public SocialMediaIconForGetDto? SocialMediaIcon { get; set; }
    public bool IsActive { get; set; }
}
