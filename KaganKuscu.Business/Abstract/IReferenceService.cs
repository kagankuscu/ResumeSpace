using KaganKuscu.Model.Dtos.ReferenceDto;
using Microsoft.AspNetCore.Http;

namespace KaganKuscu.Business.Abstract
{
    public interface IReferenceService
    {
        List<ReferenceForGetWithResumesDto> GetAllReferenceWithResumes();
        List<ReferenceForGetWithResumesDto> GetAllReferenceWithResumes(Guid userId);
        ReferenceForGetWithResumesDto AddReference(ReferenceForAddDto workExperienceDto);
        Task<bool> AddImage(IFormCollection form);
        void RemoveReference(Guid guid);
        ReferenceForGetWithResumesDto UpdateReference(ReferenceForUpdateDto workExperienceDto);
        bool ToggleStatus(Guid guid);
    }
}
