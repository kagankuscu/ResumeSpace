using AutoMapper;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Dtos.SkillsDto;
using KaganKuscu.Model.Models;

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
    }
  }
}
