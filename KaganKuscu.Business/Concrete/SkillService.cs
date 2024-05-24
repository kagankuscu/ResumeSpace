using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.Skills;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Business.Concrete
{
    public class SkillService : ISkillService
    {
        private readonly IRepository<Skill> _repository;
        private readonly IPersonService _personService;
        public SkillService(IRepository<Skill> repository, IPersonService personService)
        {
            _repository = repository;
            _personService = personService;
        }

        public void Add(Skill entity)
        {
            _repository.Add(entity);
        }

        public Skill Add(SkillForAddDto skillDto)
        {
            try
            {
                Skill skill = new Skill();
                skill.Name = skillDto.Name;
                skill.Percent = skillDto.Percent;
                skill.AppUserId = skillDto.AppUserId;
                
                foreach (var item in skillDto.Resumes)
                {
                    var person = _personService.GetById(item);
                    if (person != null)
                        skill.People.Add(person);
                }

                Add(skill);
                return skill;
            }
            catch
            {
                return new Skill();
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

        public IQueryable<Skill> GetAllByUserId(Guid userId)
        {
            return GetAll().Where(x => x.AppUserId == userId).Select(s => new Skill 
            {
                Id = s.Id,
                Guid = s.Guid,
                AppUserId = s.AppUserId,
                Name = s.Name,
                Percent = s.Percent,
                IsActive = s.IsActive,
                People = s.People
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
            Skill? skill = _repository.GetAll(s => s.Guid == skillDto.Guid).Include(s => s.People).FirstOrDefault();
            if (skill is not null)
            {
                skill.Name = skillDto.Name;
                skill.Percent = skillDto.Percent;
                
                if (skillDto.Resumes.Count == 0)
                {
                    skill.People.Clear();
                }

                var appUserId = skillDto.AppUserId.ToString();
                var deleteResumes = _personService.GetAll()
                                    .Where(p => p.AppUserId == appUserId)
                                    .Where(p => !skillDto.Resumes.Contains(p.Id));

                var resumes = _personService.GetAll()
                                    .Where(p => p.AppUserId == appUserId)
                                    .Where(p => skillDto.Resumes.Contains(p.Id));

                foreach (var resume in deleteResumes)
                {
                    if(skill.People.Contains(resume))
                        skill.People.Remove(resume);
                }
                
                foreach (var resume in resumes) 
                {
                    if (!skill.People.Contains(resume))
                        skill.People.Add(resume);
                }

                Update(skill);
            }
            return skill;
        }
    }
}