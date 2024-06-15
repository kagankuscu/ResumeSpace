using KaganKuscu.Model.Models;

namespace KaganKuscu.Repository.Abstract;

public interface ISkillRepository : IRepository<Skill>
{
    Skill? AddSkill(Skill skill);
    IQueryable<Skill> GetAllSkillWithResumes();
    IQueryable<Skill> GetAllSkillWithResumes(Guid userId);
    bool ToggleStatus(Guid guid);
    void RemoveSkill(Guid guid);
    Skill? UpdateSkill(Skill skill);
}
