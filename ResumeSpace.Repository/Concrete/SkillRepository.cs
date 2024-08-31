using ResumeSpace.DataAccess;
using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ResumeSpace.Repository.Concrete;

public class SkillRepository : Repository<Skill>, ISkillRepository
{
    public SkillRepository(AppDbContext context) : base(context)
    {
    }

    public Skill? AddSkill(Skill skill)
    {
        Add(skill);

        return GetAllSkillWithResumes().Where(x => x.Id == skill.Id).FirstOrDefault();
    }

    public IQueryable<Skill> GetAllSkillWithResumes()
    {
        return GetAll().Include(x => x.ResumesSkills).ThenInclude(x => x.Resume);
    }

    public IQueryable<Skill> GetAllSkillWithResumes(Guid userId)
    {
        return GetAll(x => x.AppUserId == userId).Include(x => x.ResumesSkills).ThenInclude(x => x.Resume);
    }

    public bool ToggleStatus(Guid guid)
    {
        Skill? skill = GetById(guid);
        if (skill is null)
            return false;

        skill.IsActive = !skill.IsActive;
        Update(skill);
        return true;
    }

    public Skill? UpdateSkill(Skill skill)
    {
        Update(skill);
        return GetAllSkillWithResumes().Where(x => x.Guid == skill.Guid).FirstOrDefault();
    }
}
