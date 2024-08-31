namespace ResumeSpace.Model.Dtos.UserDto
{
    public class UserForResetPasswordDto
    {
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string? Username { get; set; }
        public string? Token { get; set; }
    }
}