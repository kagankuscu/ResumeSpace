using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace KaganKuscu.Model.Models
{
    public class AppUser : IdentityUser
    {
        public string? ProfilePhoto { get; set; }
    }
}