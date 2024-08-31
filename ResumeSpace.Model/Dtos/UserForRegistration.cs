namespace ResumeSpace.Model.Dtos
{
    public record UserForRegistration
    {
        public string Username { get; init; } = string.Empty;
        public string Fullname { get; init; } = string.Empty;
        public string? PhoneNumber { get; init; }
        public string Password { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
    }
}