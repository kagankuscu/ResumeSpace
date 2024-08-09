using KaganKuscu.Model.Dtos.EducationDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Model.Rel;
using KaganKuscu.Model.SocialMediaDto;

namespace KaganKuscu.Model.Dtos.ResumesDto
{
    public class ResumeForGetWithDetailsDto
    {
        public string ResumeName { get; init; } = string.Empty;
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
        public string? About { get; init; }

        public virtual List<EducationForGetDto> Educations { get; set; } = [];
        public virtual List<SocialMediaForGetDto> SocialMedias { get; set; } = [];
        public virtual List<WorkExperience> WorkExperiences { get; set; } = [];
        public virtual List<Reference> References { get; set; } = [];
        public virtual List<Skill> Skills { get; set; } = [];
        public virtual List<Interest> Interests { get; set; } = [];
    }
}
