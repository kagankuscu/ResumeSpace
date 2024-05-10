using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Dtos
{
    public record UserForRegistration
    {
        public string? Username { get; init; }
        public string? Password { get; init; }
        public string? Email { get; init; }
    }
}