using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Http;

namespace KaganKuscu.Business.Abstract
{
    public interface IResumeService
    {
        ResumeForGetWithDetailsDto AddResume(ResumeForAddDto resumeDto);
        IQueryable<ResumeForAppUserDto> GetAllByAppUserGuid(Guid guid);
        IQueryable<ResumeForGetWithDetailsDto> GetAllResumeDto();
        bool ToggleStatus(Guid guid);
        void RemoveResume(Guid guid);
        Task<bool> UploadFiles(IFormCollection form, string username, Resume resume);
        bool UpdateStatusForUserGuid(Guid guid);
        ResumeForGetWithDetailsDto UpdateResume(ResumeForUpdateDto resumeDto);
    }
}
