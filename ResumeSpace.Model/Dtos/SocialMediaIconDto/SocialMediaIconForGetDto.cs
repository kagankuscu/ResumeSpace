namespace ResumeSpace.Model.SocialMediaDto;
public record SocialMediaIconForGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CssClass { get; set; } = string.Empty;
}
