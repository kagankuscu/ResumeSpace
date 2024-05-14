using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace KaganKuscu.Model.Models
{
    [Table("People")]
    public class Person : BaseModel
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string? SecondPhone { get; set; }
        public string? About { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
        public string? ResumePath { get; set; }
        public string? Interest { get; set; }
        public string AppUserId { get; set; } = string.Empty;

        public AppUser? AppUser { get; set; }
        public virtual ICollection<SocialMedia> SocialMedias { get; set; } = new List<SocialMedia>();
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public virtual ICollection<Education> Educations { get; set; } = new List<Education>();
        public virtual ICollection<Reference> References { get; set; } = new List<Reference>();
        public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
        public virtual ICollection<Interest> Interests { get; set; } = new List<Interest>();
    }
}