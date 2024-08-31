namespace ResumeSpace.Model.Dtos.QuoteDto;

public record QuoteForUpdateDto
{
    public Guid Guid { get; set; }
    public string Owner { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}
