namespace KaganKuscu.Model.SocialMediaDto;

public record SocialMediaForGetDto
{
    public Guid Guid { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string IconCssClass { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}
