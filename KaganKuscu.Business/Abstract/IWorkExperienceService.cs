using KaganKuscu.Model.Dtos.WorkExperienceDto;
using KaganKuscu.Model.Models;

namespace KaganKuscu.Business.Abstract
{
 public interface IWorkExperienceService : IBaseService<WorkExperience>
 {
    List<WorkExperienceForGetDto> GetAllWorkExperience();
    List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes();
    List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes(Guid userId);
    WorkExperienceForGetWithResumesDto AddWorkExperience(WorkExperienceForAddDto workExperienceDto);
    WorkExperienceForGetWithResumesDto UpdateWorkExperience(WorkExperienceForUpdateDto workExperienceDto);
    bool ToggleStatus(Guid guid); 
 }    
}
