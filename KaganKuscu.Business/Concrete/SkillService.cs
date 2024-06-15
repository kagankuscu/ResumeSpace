using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.SkillsDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;

namespace KaganKuscu.Business.Concrete
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
            throw new NotImplementedException();
        }

        public bool ToggleStatus(Guid guid) => _repository.ToggleStatus(guid);

        public SkillForGetWithResumesDto UpdateSkill(SkillForUpdateDto skillDto)
        {
            Skill? skill = _mapper.Map<Skill>(skillDto);

            return _mapper.Map<SkillForGetWithResumesDto>(_repository.UpdateSkill(skill));
        }
    }
}
