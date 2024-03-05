using KaganKuscu.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Dtos
{
    public class PersonDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Interest { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string ResumePath { get; set; }

        public virtual List<SocialMedia> SocialMedias { get; set; } = new List<SocialMedia>();
        public virtual List<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public virtual List<Education> Educations { get; set; } = new List<Education>();
        public virtual List<Reference> References { get; set; } = new List<Reference>();
        public virtual List<Skill> Skills { get; set; } = new List<Skill>();
        public virtual List<Interest> Interests { get; set; } = new List<Interest>();
    }
}
