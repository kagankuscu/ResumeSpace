using KaganKuscu.Model.Models;

namespace KaganKuscu.Repository.Abstract;

public interface ISkillRepository : IRepository<Skill>
{
    Skill? AddSkill(Skill skill);
    IQueryable<Skill> GetAllSkillWithResumes();
    IQueryable<Skill> GetAllSkillWithResumes(Guid userId);
    public void RemoveSkill(Guid guid) => Remove(guid);
    bool ToggleStatus(Guid guid);
    Skill? UpdateSkill(Skill skill);
}
