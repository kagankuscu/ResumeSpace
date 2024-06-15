using KaganKuscu.Model.Dtos.SkillsDto;

namespace KaganKuscu.Business.Abstract
{
    public interface ISkillService
    {
        SkillForGetWithResumesDto AddSkill(SkillForAddDto skillDto);
        List<SkillForGetWithResumesDto> GetAllSkillWithResumes();
        List<SkillForGetWithResumesDto> GetAllSkillWithResumes(Guid userId);
        bool ToggleStatus(Guid guid);
        void RemoveSkill(Guid guid);
        SkillForGetWithResumesDto UpdateSkill(SkillForUpdateDto skillDto);
    }
}
