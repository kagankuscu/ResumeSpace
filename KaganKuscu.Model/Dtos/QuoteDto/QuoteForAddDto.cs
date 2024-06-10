namespace KaganKuscu.Model.Dtos.QuoteDto;

public record QuoteForAddDto
{
    public string Owner { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}
