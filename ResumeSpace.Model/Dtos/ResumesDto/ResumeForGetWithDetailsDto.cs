using ResumeSpace.Model.Dtos.EducationDto;
using ResumeSpace.Model.Dtos.ReferenceDto;
using ResumeSpace.Model.Dtos.SkillsDto;
using ResumeSpace.Model.Dtos.WorkExperienceDto;
using ResumeSpace.Model.Models;
using ResumeSpace.Model.Rel;
using ResumeSpace.Model.SocialMediaDto;

namespace ResumeSpace.Model.Dtos.ResumesDto
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
        public virtual List<WorkExperienceForGetDto> WorkExperiences { get; set; } = [];
        public virtual List<ReferenceForGetDto> References { get; set; } = [];
        public virtual List<SkillForGetDto> Skills { get; set; } = [];
        public virtual List<Interest> Interests { get; set; } = [];
    }
}
