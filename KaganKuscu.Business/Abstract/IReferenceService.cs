using KaganKuscu.Model.Dtos.ReferenceDto;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Http;

namespace KaganKuscu.Business.Abstract
{
 public interface IReferenceService : IBaseService<Reference>
 {
    List<ReferenceForGetDto> GetAllReference();
    List<ReferenceForGetWithResumesDto> GetAllReferenceWithResumes();
    List<ReferenceForGetWithResumesDto> GetAllReferenceWithResumes(Guid userId);
    ReferenceForGetWithResumesDto AddReference(ReferenceForAddDto workExperienceDto);
    Task<bool> AddImage(IFormCollection form);
    ReferenceForGetWithResumesDto UpdateReference(ReferenceForUpdateDto workExperienceDto);
    bool ToggleStatus(Guid guid); 
 }    
}
