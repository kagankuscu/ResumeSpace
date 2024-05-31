using KaganKuscu.Model.Dtos.EducationDto;
using KaganKuscu.Model.Models;

namespace KaganKuscu.Business.Abstract
{
  public interface IEducationService : IBaseService<Education>
  {
    List<EducationForGetDto> GetAllEducation();
    List<EducationForGetWithResumesDto> GetAllEducationWithResumes();
    List<EducationForGetWithResumesDto> GetAllEducationWithResumes(Guid userId);
    EducationForGetWithResumesDto AddEducation(EducationForAddDto educationDto);
    EducationForGetWithResumesDto UpdateEducation(EducationForUpdateDto educationDto);
    bool ToggleStatus(Guid guid); 
  }
}
