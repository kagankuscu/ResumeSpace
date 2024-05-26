using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaganKuscu.Model.Dtos.Skills;
using KaganKuscu.Model.Models;

namespace KaganKuscu.Business.Abstract
{
    public interface ISkillService : IBaseService<Skill>
    {
        IQueryable<Skill> GetAllByUserId(Guid userId);
        SkillForAddDto Add(SkillForAddDto skillDto);
        Skill Update(SkillForUpdateDto skillDto);
        bool ToggleStatus(Guid guid);
    }
}
