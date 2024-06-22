namespace KaganKuscu.Model.Dtos.ResumesDto;

public record ResumeForAddDto
{
    public Guid Guid { get; init; }
    public string AppUserId { get; set; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public int Age { get; init; }
    public string Address { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Interest { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public string ImagePath { get; init; } = string.Empty;
    public string ResumePath { get; init; } = string.Empty;
}
