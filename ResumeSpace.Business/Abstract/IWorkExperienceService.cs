using ResumeSpace.Model.Dtos.WorkExperienceDto;

namespace ResumeSpace.Business.Abstract
{
 public interface IWorkExperienceService
 {
    List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes();
    List<WorkExperienceForGetWithResumesDto> GetAllWorkExperienceWithResumes(Guid userId);
    WorkExperienceForGetWithResumesDto AddWorkExperience(WorkExperienceForAddDto workExperienceDto);
    void RemoveWorkExperience(Guid guid);
    bool ToggleStatus(Guid guid); 
    WorkExperienceForGetWithResumesDto UpdateWorkExperience(WorkExperienceForUpdateDto workExperienceDto);
 }    
}
