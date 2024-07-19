namespace KaganKuscu.Model.Dtos.ResumesDto;

public record ResumeForUpdateDto
{
    public Guid Guid { get; init; }
    public string ResumeName { get; init; } = string.Empty;
    public string FullName { get; init; } = string.Empty;
    public string BirthDate { get; init; } = string.Empty;
    public string? Address { get; init; }
    public string Email { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public string? SecondPhone { get; init; }
    public string? About { get; init; }
    public string Title { get; init; } = string.Empty;
    public string? ImagePath { get; init; }
    public string? ResumePath { get; init; }
    public string? Interest { get; init; }
}
