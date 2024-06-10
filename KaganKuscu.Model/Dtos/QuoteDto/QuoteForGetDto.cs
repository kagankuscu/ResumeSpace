namespace KaganKuscu.Model.Dtos.QuoteDto;

public record QuoteForGetDto
{
    public Guid Guid { get; set; }
    public string Owner { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}
