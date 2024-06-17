using KaganKuscu.Model.Dtos.WorkExperienceDto;

namespace KaganKuscu.Business.Abstract
{
 public interface IWorkExperienceService
 {
    List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes();
    List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes(Guid userId);
    WorkExperienceForGetWithResumesDto AddWorkExperience(WorkExperienceForAddDto workExperienceDto);
    WorkExperienceForGetWithResumesDto UpdateWorkExperience(WorkExperienceForUpdateDto workExperienceDto);
    bool ToggleStatus(Guid guid); 
 }    
}
