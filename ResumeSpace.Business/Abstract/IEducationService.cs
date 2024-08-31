using ResumeSpace.Model.Dtos.EducationDto;

namespace ResumeSpace.Business.Abstract
{
  public interface IEducationService
  {
    EducationForGetWithResumesDto AddEducation(EducationForAddDto educationDto);
    List<EducationForGetDto> GetAllEducation();
    List<EducationForGetWithResumesDto> GetAllEducationWithResumes();
    List<EducationForGetWithResumesDto> GetAllEducationWithResumes(Guid userId);
    bool ToggleStatus(Guid guid); 
    EducationForGetWithResumesDto UpdateEducation(EducationForUpdateDto educationDto);
    void RemoveEducation(Guid guid);
  }
}
