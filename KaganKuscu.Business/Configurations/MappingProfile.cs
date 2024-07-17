using AutoMapper;
using KaganKuscu.Model.Dtos.EducationDto;
using KaganKuscu.Model.Dtos.QuoteDto;
using KaganKuscu.Model.Dtos.ReferenceDto;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Dtos.SkillsDto;
using KaganKuscu.Model.Dtos.WorkExperienceDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Model.Rel;
using KaganKuscu.Model.SocialMediaDto;

namespace KaganKuscu.Business.Configurations
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Resume, ResumeForAddDto>().ReverseMap();
      CreateMap<Resume, ResumeForAppUserDto>().ReverseMap();
      CreateMap<Resume, ResumeForGetWithDetailsDto>().ReverseMap();
      CreateMap<Resume, ResumeForUpdateDto>().ReverseMap();
      CreateMap<ResumeSkill, ResumeForGetDto>().ReverseMap();
      CreateMap<Resume, ResumeForGetDto>().ReverseMap();
      CreateMap<ResumeSkill, SkillForGetDto>().ReverseMap();
      CreateMap<ResumeSkill, Resume>().ReverseMap();
      CreateMap<ResumeSkill, Skill>().ReverseMap();

      CreateMap<Skill, SkillForGetWithResumesDto>()
        .ForMember(s => s.Resumes, opt => opt.MapFrom(x => x.ResumesSkills.Select(x => x.Resume)))
        .ReverseMap();
      CreateMap<Skill, SkillForAddDto>().ReverseMap();
      CreateMap<Skill, SkillForGetDto>().ReverseMap();
      CreateMap<Skill, SkillForUpdateDto>().ReverseMap();

      CreateMap<Education, EducationForGetDto>().ReverseMap();
      CreateMap<Education, EducationForGetWithResumesDto>()
        .ForMember(er => er.Resumes, opt => opt.MapFrom(e => e.ResumesEducations.Select(x => x.Resume)));
      CreateMap<Education, EducationForAddDto>().ReverseMap();
      CreateMap<Education, ResumesEducations>().ReverseMap();
      CreateMap<Education, EducationForUpdateDto>().ReverseMap();

      CreateMap<WorkExperience, WorkExperienceForGetDto>().ReverseMap();
      CreateMap<WorkExperience, WorkExperienceForGetWithResumesDto>().ReverseMap();
      CreateMap<WorkExperience, WorkExperienceForAddDto>().ReverseMap();
      CreateMap<WorkExperience, WorkExperienceForUpdateDto>().ReverseMap();

      CreateMap<Reference, ReferenceForGetDto>().ReverseMap();
      CreateMap<Reference, ReferenceForGetWithResumesDto>().ReverseMap();
      CreateMap<Reference, ReferenceForAddDto>().ReverseMap();
      CreateMap<Reference, ReferenceForUpdateDto>().ReverseMap();

      CreateMap<SocialMediaIcon, SocialMediaIconForGetDto>().ReverseMap();

      CreateMap<SocialMedia, SocialMediaForGetDto>().ReverseMap();
      CreateMap<SocialMedia, SocialMediaForGetWithResumesDto>().ReverseMap();
      CreateMap<SocialMedia, SocialMediaForAddDto>().ReverseMap();
      CreateMap<SocialMedia, SocialMediaForUpdateDto>().ReverseMap();
      CreateMap<SocialMediaForUpdateDto, SocialMediaForGetWithResumesDto>().ReverseMap();

      CreateMap<Quote, QuoteForAddDto>().ReverseMap();
      CreateMap<Quote, QuoteForGetDto>().ReverseMap();
      CreateMap<Quote, QuoteForUpdateDto>().ReverseMap();
    }
  }
}
