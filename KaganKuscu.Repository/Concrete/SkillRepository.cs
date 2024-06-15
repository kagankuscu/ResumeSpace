using KaganKuscu.DataAccess;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;

namespace KaganKuscu.Repository.Concrete;

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
        throw new NotImplementedException();
    }

    public IQueryable<Skill> GetAllSkillWithResumes(Guid userId)
    {
        throw new NotImplementedException();
    }

    public void RemoveSkill(Guid guid)
    {
        throw new NotImplementedException();
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
        Skill? real = GetAllSkillWithResumes().Where(x => x.Guid == skill.Guid).FirstOrDefault();

        if (real is null)
            return null; 

        real.ResumesSkills.Clear();

        foreach (var item in skill.ResumesSkills)
        {
            if (!real.ResumesSkills.Select(rs => rs.ResumeId).Contains(item.ResumeId))
            {
                real.ResumesSkills.Add(item);
            }
        }

        Update(real);

        return GetAllSkillWithResumes().Where(x => x.Guid == real.Guid).FirstOrDefault();
    }
}
