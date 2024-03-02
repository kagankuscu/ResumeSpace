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
        public string Description { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string ResumePath { get; set; }

        public virtual ICollection<SocialMedia> SocialMedias { get; set; } = new List<SocialMedia>();
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public virtual ICollection<Education> Educations { get; set; } = new List<Education>();
        public virtual ICollection<Reference> References { get; set; } = new List<Reference>();
        public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
    }
}
