using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSpace.Model.Dtos
{
    public record UserForAuthentication
    {
        public string? Username { get; init; }
        public string? Password { get; init; }
        public bool RememberMe { get; init; }
    }
}