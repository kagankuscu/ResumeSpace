using AutoMapper;
using ResumeSpace.Business.Abstract;
using ResumeSpace.Model.Dtos.SkillsDto;
using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ResumeSpace.Business.Concrete
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _repository;
        private readonly IMapper _mapper;

        public SkillService(ISkillRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public SkillForGetWithResumesDto AddSkill(SkillForAddDto skillDto)
        {
            Skill skill = _mapper.Map<Skill>(skillDto);

            return _mapper.Map<SkillForGetWithResumesDto>(_repository.AddSkill(skill));
        }

        public List<SkillForGetWithResumesDto> GetAllSkillWithResumes() => _mapper.Map<List<SkillForGetWithResumesDto>>(_repository.GetAllSkillWithResumes());

        public List<SkillForGetWithResumesDto> GetAllSkillWithResumes(Guid userId) => _mapper.Map<List<SkillForGetWithResumesDto>>(_repository.GetAllSkillWithResumes(userId));

        public void RemoveSkill(Guid guid)
        {
            _repository.RemoveSkill(guid);
        }

        public bool ToggleStatus(Guid guid) => _repository.ToggleStatus(guid);

        public SkillForGetWithResumesDto UpdateSkill(SkillForUpdateDto skillDto)
        {
            Skill? real = _repository.GetAll(x => x.Guid == skillDto.Guid).Include(x => x.ResumesSkills).FirstOrDefault();
            foreach (var item in real.ResumesSkills)
            {
                if (real.ResumesSkills.Select(rs => rs.ResumeId).Contains(item.ResumeId))
                {
                    skillDto.ResumesSkills.Remove(item);
                }
            }
            Skill? skill = _mapper.Map<SkillForUpdateDto, Skill>(skillDto, real!);

            return _mapper.Map<SkillForGetWithResumesDto>(_repository.UpdateSkill(skill));
        }
    }
}
