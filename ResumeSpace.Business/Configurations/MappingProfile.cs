using AutoMapper;
using ResumeSpace.Model.Dtos;
using ResumeSpace.Model.Dtos.EducationDto;
using ResumeSpace.Model.Dtos.QuoteDto;
using ResumeSpace.Model.Dtos.ReferenceDto;
using ResumeSpace.Model.Dtos.ResumesDto;
using ResumeSpace.Model.Dtos.SkillsDto;
using ResumeSpace.Model.Dtos.UserDto;
using ResumeSpace.Model.Dtos.WorkExperienceDto;
using ResumeSpace.Model.Models;
using ResumeSpace.Model.Rel;
using ResumeSpace.Model.SocialMediaDto;

namespace ResumeSpace.Business.Configurations
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Resume, ResumeForAddDto>().ReverseMap();
      CreateMap<Resume, ResumeForAppUserDto>().ReverseMap();
      CreateMap<Resume, ResumeForGetWithDetailsDto>()
        .ForMember(r => r.Educations, opt => opt.MapFrom(r => r.ResumesEducations.Select(re => re.Education)))
        .ForMember(r => r.WorkExperiences, opt => opt.MapFrom(r => r.ResumesWorkExperiences.Select(rw => rw.WorkExperience)))
        .ForMember(r => r.SocialMedias, opt => opt.MapFrom(r => r.ResumesSocialMedias.Select(rs => rs.SocialMedia)))
        .ForMember(r => r.Skills, opt => opt.MapFrom(r => r.ResumesSkills.Select(rs => rs.Skill)))
        .ForMember(r => r.References, opt => opt.MapFrom(r => r.ResumesReferences.Select(rs => rs.Reference)))
        .ReverseMap();
      CreateMap<Resume, ResumeForUpdateDto>().ReverseMap();
      CreateMap<Resume, ResumeForGetList>()
        .ForMember(r => r.UserName, opt => opt.MapFrom(r => r.AppUser!.UserName))
        .ReverseMap();
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
      CreateMap<WorkExperience, WorkExperienceForGetWithResumesDto>()
        .ForMember(we => we.Resumes, opt => opt.MapFrom(x => x.ResumesWorkExperiences.Select(x => x.Resume)))
        .ReverseMap();
      CreateMap<WorkExperience, WorkExperienceForAddDto>().ReverseMap();
      CreateMap<WorkExperience, WorkExperienceForUpdateDto>().ReverseMap();

      CreateMap<Reference, ReferenceForGetDto>().ReverseMap();
      CreateMap<Reference, ReferenceForGetWithResumesDto>()
        .ForMember(r => r.Resumes, opt => opt.MapFrom(x => x.ResumesReferences.Select(x => x.Resume)))
        .ReverseMap();
      CreateMap<Reference, ReferenceForAddDto>().ReverseMap();
      CreateMap<Reference, ReferenceForUpdateDto>().ReverseMap();

      CreateMap<SocialMediaIcon, SocialMediaIconForGetDto>().ReverseMap();

      CreateMap<SocialMedia, SocialMediaForGetDto>().ReverseMap();
      CreateMap<SocialMedia, SocialMediaForGetWithResumesDto>()
        .ForMember(sm => sm.Resumes, opt => opt.MapFrom(x => x.ResumesSocialMedias.Select(x => x.Resume)))
        .ReverseMap();
      CreateMap<SocialMedia, SocialMediaForAddDto>().ReverseMap();
      CreateMap<SocialMedia, SocialMediaForUpdateDto>().ReverseMap();
      CreateMap<SocialMediaForUpdateDto, SocialMediaForGetWithResumesDto>().ReverseMap();

      CreateMap<Quote, QuoteForAddDto>().ReverseMap();
      CreateMap<Quote, QuoteForGetDto>().ReverseMap();
      CreateMap<Quote, QuoteForUpdateDto>().ReverseMap();

      CreateMap<AppUser, UserForGetDto>().ReverseMap();
      CreateMap<AppUser, UserForUpdateDto>().ReverseMap();
      CreateMap<AppUser, UserForRegistration>().ReverseMap();
    }
  }
}
