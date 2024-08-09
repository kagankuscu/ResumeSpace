using KaganKuscu.Model.Rel;

namespace KaganKuscu.Model.Dtos.EducationDto
{
    public record EducationForGetDto
    {
      public string Name { get; set; } = string.Empty;
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public string Role { get; set; } = string.Empty;
      public string Description { get; set; } = string.Empty;
    }
}
