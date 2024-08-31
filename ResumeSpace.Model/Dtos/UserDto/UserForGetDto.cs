namespace ResumeSpace.Model.Dtos.UserDto
{
    public class UserForGetDto
    {
        public string? FullName { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? ProfilePhoto { get; set; }
    }
}