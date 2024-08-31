using Microsoft.AspNetCore.Identity;

namespace ResumeSpace.Model.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
        public string? ProfilePhoto { get; set; }
    }
}