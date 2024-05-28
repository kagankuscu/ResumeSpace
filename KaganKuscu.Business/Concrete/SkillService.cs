using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Dtos.SkillsDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Business.Concrete
{
    public class SkillService : ISkillService
    {
        private readonly IRepository<Skill> _repository;
        private readonly IResumeService _resumeService;
        private readonly IMapper _mapper;

        public SkillService(IRepository<Skill> repository, IResumeService resumeService, IMapper mapper)
        {
            _repository = repository;
            _resumeService = resumeService;
            _mapper = mapper;
        }

        public void Add(Skill entity)
        {
            _repository.Add(entity);
        }

        public SkillForAddDto Add(SkillForAddDto skillDto)
        {
            try
            {
                Skill skill = _mapper.Map<Skill>(skillDto); 
              
                var resumes = _resumeService.GetAll().Where(r => skillDto.Resumes.Select(r => r.Id).Contains(r.Id)).ToList();

                 List<ResumeSkill> resumeSkill = new List<ResumeSkill>();
                 
                 foreach (var item in resumes)
                 {
                     // var resume = _resumeService.GetById(item.Id);
                     // if (resume != null)
                     resumeSkill.Add(new ResumeSkill { Resume = item }); 
                 }

                skill.ResumesSkills = resumeSkill; 
                Add(skill);
                var data = _mapper.Map<SkillForAddDto>(skill);
                data.Resumes = _mapper.Map<List<ResumeForGetDto>>(_resumeService.GetAll().Where(r => r.ResumesSkills.Any(rs => rs.SkillId == skill.Id)).ToList());
                return data; 
            }
            catch
            {
                return new SkillForAddDto();
            }
        }

        public void AddRange(IEnumerable<Skill> entities)
        {
            _repository.AddRange(entities);
        }

        public IQueryable<Skill> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<SkillForGetDto> GetAllByUserId(Guid userId)
        {
            return GetAll().Where(x => x.AppUserId == userId).Select(s => new SkillForGetDto 
            {
                Id = s.Id,
                Guid = s.Guid,
                AppUserId = s.AppUserId,
                Name = s.Name,
                Percent = s.Percent,
                IsActive = s.IsActive,
                Resumes = s.ResumesSkills.Select(r => r.Resume!).ToList()
            });
        }

        public Skill? GetById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public Skill? GetById(Guid guid)
        {
            return _repository.GetById(guid);
        }

        public void Remove(Skill entity)
        {
            _repository.Remove(entity);
        }

        public void Remove(int id)
        {
            Skill? skill = _repository.GetById(id);
            if (skill is not null)
                Remove(skill);
        }

        public void Remove(Guid guid)
        {
            Skill? skill = _repository.GetById(guid);
            if (skill is not null)
                Remove(skill);
        }

        public bool ToggleStatus(Guid guid)
        {
            Skill? skill= _repository.GetById(guid);
            if (skill is null)
                return false;
            
            skill.IsActive = !skill.IsActive;
            _repository.Update(skill);
            return true;
        }

        public void Update(Skill entity)
        {
            _repository.Update(entity);
        }

        public void Update(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public Skill Update(SkillForUpdateDto skillDto)
        {
            Skill? skill = _repository.GetAll(s => s.Guid == skillDto.Guid).Include(s => s.ResumesSkills).FirstOrDefault();
            if (skill is not null)
            {
                skill.Name = skillDto.Name;
                skill.Percent = skillDto.Percent;
                
                if (skillDto.Resumes.Count == 0)
                {
                    skill.ResumesSkills.Clear();
                }

                var appUserId = skillDto.AppUserId.ToString();
                var deleteResumes = _resumeService.GetAll()
                                    .Where(p => p.AppUserId == appUserId)
                                    .Where(p => !skillDto.Resumes.Contains(p.Id));

                var resumes = _resumeService.GetAll()
                                    .Where(p => p.AppUserId == appUserId)
                                    .Where(p => skillDto.Resumes.Contains(p.Id));

                foreach (var resume in deleteResumes)
                {
                    if(skill.ResumesSkills.Contains(new ResumeSkill
                    {
                        Resume = resume
                    }))
                        skill.ResumesSkills.Remove(new ResumeSkill
                        {
                            Resume = resume
                        });
                }
                
                foreach (var resume in resumes) 
                {
                    if (!skill.ResumesSkills.Contains(new ResumeSkill
                        {
                            Resume = resume
                        }))
                        skill.ResumesSkills.Add(new ResumeSkill
                        {
                            Resume = resume
                        });
                }

                Update(skill);
            }
            return skill;
        }
    }
}
