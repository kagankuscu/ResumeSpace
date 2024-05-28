using KaganKuscu.Model.Dtos.SkillsDto;
using KaganKuscu.Model.Models;

namespace KaganKuscu.Business.Abstract
{
    public interface ISkillService : IBaseService<Skill>
    {
        IQueryable<SkillForGetDto> GetAllByUserId(Guid userId);
        SkillForAddDto Add(SkillForAddDto skillDto);
        Skill Update(SkillForUpdateDto skillDto);
        bool ToggleStatus(Guid guid);
    }
}
