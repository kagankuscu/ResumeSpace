using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Http;

namespace KaganKuscu.Business.Abstract
{
    public interface IResumeService
    {
        ResumeForGetDto AddResume(ResumeForAddDto resumeDto);
        ICollection<ResumeForAppUserDto> GetAllByAppUserGuid(Guid guid);
        ICollection<ResumeForGetWithDetailsDto> GetAllResumeDto();
        bool ToggleStatus(Guid guid);
        void RemoveResume(Guid guid);
        Task<ResumeForGetDto> UploadFiles(IFormCollection form, string username);
        bool UpdateStatusForUserGuid(Guid guid);
        ResumeForGetDto UpdateResume(ResumeForUpdateDto resumeDto);
    }
}
