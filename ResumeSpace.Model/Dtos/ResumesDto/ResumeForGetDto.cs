namespace ResumeSpace.Model.Dtos.ResumesDto
{
  public record ResumeForGetDto
  {
    public Guid Guid { get; init; }
    public string ResumeName { get; init; } = string.Empty;
    public string FullName { get; init; } = string.Empty;
    public DateTime BirthDate { get; init; }
    public string? Address { get; init; }
    public string Email { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public string? SecondPhone { get; init; }
    public string? About { get; init; }
    public string Title { get; init; } = string.Empty;
    public string? ImagePath { get; init; }
    public string? ResumePath { get; init; }
    public string? Interest { get; init; }
    public string AppUserId { get; init; } = string.Empty;
    public bool IsActive { get; init; }
  }
}
