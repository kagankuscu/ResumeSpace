using AutoMapper;
using KaganKuscu.Model.Dtos.EducationDto;
using KaganKuscu.Model.Dtos.ReferenceDto;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Dtos.SkillsDto;
using KaganKuscu.Model.Dtos.WorkExperienceDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Model.Rel;

namespace KaganKuscu.Business.Configurations
{
  public class MappingProfile : Profile    
  {
    public MappingProfile()
    {
      CreateMap<ResumeSkill, ResumeForGetDto>().ReverseMap();
      CreateMap<Resume, ResumeForGetDto>().ReverseMap();
      CreateMap<ResumeSkill, SkillForGetDto>().ReverseMap();
      CreateMap<ResumeSkill, Resume>().ReverseMap();
      CreateMap<ResumeSkill, Skill>().ReverseMap();

      CreateMap<Skill, SkillForAddDto>().ReverseMap();
      CreateMap<Skill, SkillForGetDto>().ReverseMap();
      CreateMap<Skill, SkillForUpdateDto>().ReverseMap();

      CreateMap<Education, EducationForGetDto>().ReverseMap();
      CreateMap<Education, EducationForGetWithResumesDto>().ReverseMap();
      CreateMap<Education, EducationForAddDto>().ReverseMap();
      CreateMap<Education, ResumesEducations>().ReverseMap();
      CreateMap<Education, EducationForGetWithResumesDto>().ReverseMap();
      CreateMap<Education, EducationForUpdateDto>().ReverseMap();

      CreateMap<WorkExperience, WorkExperienceForGetDto>().ReverseMap();
      CreateMap<WorkExperience, WorkExperienceForGetWithResumesDto>().ReverseMap();
      CreateMap<WorkExperience, WorkExperienceForAddDto>().ReverseMap();
      CreateMap<WorkExperience, WorkExperienceForUpdateDto>().ReverseMap();

      CreateMap<Reference, ReferenceForGetDto>().ReverseMap();
      CreateMap<Reference, ReferenceForGetWithResumesDto>().ReverseMap();
      CreateMap<Reference, ReferenceForAddDto>().ReverseMap();
      CreateMap<Reference, ReferenceForUpdateDto>().ReverseMap();
    }
  }
}
