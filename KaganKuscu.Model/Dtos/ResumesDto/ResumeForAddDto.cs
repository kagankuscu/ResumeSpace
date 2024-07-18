namespace KaganKuscu.Model.Dtos.ResumesDto;

public record ResumeForAddDto
{
    public string ResumeName { get; init; } = string.Empty;
    public string AppUserId { get; set; } = string.Empty;
    public string FullName { get; init; } = string.Empty;
    public string BirthDate { get; init; } = string.Empty;
    public string Address { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Interest { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public string ImagePath { get; init; } = string.Empty;
    public string ResumePath { get; init; } = string.Empty;
}
