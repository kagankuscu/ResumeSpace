using KaganKuscu.Model.Models;
using KaganKuscu.Model.Rel;
using KaganKuscu.Model.SocialMediaDto;

namespace KaganKuscu.Model.Dtos.ResumesDto
{
    public class ResumeForGetWithDetailsDto
    {
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Interest { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string ResumePath { get; set; } = string.Empty;

        public virtual List<ResumesEducations> ResumesEducations { get; set; } = [];
        public virtual List<SocialMediaForGetDto> SocialMedia { get; set; } = new List<SocialMediaForGetDto>();
        public virtual List<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public virtual List<Reference> References { get; set; } = new List<Reference>();
        public virtual List<Skill> Skills { get; set; } = new List<Skill>();
        public virtual List<Interest> Interests { get; set; } = new List<Interest>();
    }
}
