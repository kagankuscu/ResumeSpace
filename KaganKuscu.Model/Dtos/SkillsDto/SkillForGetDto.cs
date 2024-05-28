using KaganKuscu.Model.Models;

namespace KaganKuscu.Model.Dtos.SkillsDto
{
  public record SkillForGetDto
  {
    public int Id { get; init; }
    public Guid Guid { get; init; }
    public Guid AppUserId { get; init; }
    public string? Name { get; init; }
    public int Percent { get; init; }
    public bool IsActive { get; init; }
    public ICollection<Resume>? Resumes { get; init; }
  }
}
