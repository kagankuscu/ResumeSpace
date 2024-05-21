using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Dtos.PersonDto
{
    public record PersonForAppUserDto
    {
        public Guid Guid { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string? SecondPhone { get; set; }
        public string About { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
        public string? ResumePath { get; set; }
        public string? Interest { get; set; }
        public bool IsActive { get; set; }
        public string AppUserId { get; set; } = Guid.NewGuid().ToString();
    }
}