using Microsoft.AspNetCore.Identity;

namespace KaganKuscu.Model.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
        public string? ProfilePhoto { get; set; }
    }
}