using KaganKuscu.Model.Dtos.EducationDto;

namespace KaganKuscu.Business.Abstract
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
