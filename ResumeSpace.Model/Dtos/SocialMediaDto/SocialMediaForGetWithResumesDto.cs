using ResumeSpace.Model.Dtos.ResumesDto;

namespace ResumeSpace.Model.SocialMediaDto;

public record SocialMediaForGetWithResumesDto
{
    public Guid Guid { get; init; }
    public string Url { get; init; } = string.Empty;
    public SocialMediaIconForGetDto? SocialMediaIcon { get; set; }
    public bool IsActive { get; init; }
    public List<ResumeForGetDto> Resumes { get; set; } = [];
}
