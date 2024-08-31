using ResumeSpace.Model.Dtos.ResumesDto;
using ResumeSpace.Model.Models;
using Microsoft.AspNetCore.Http;

namespace ResumeSpace.Business.Abstract
{
    public interface IResumeService
    {
        ResumeForGetDto AddResume(ResumeForAddDto resumeDto);
        ICollection<ResumeForAppUserDto> GetAllByAppUserGuid(Guid guid);
        ICollection<ResumeForAppUserDto> GetAllResumeDto();
        ResumeForGetWithDetailsDto GetResumeWithDetailslByUsername(string username);
        ICollection<ResumeForGetList> GetAllUsers();
        bool ToggleStatus(Guid guid);
        void RemoveResume(Guid guid);
        Task<ResumeForGetDto> UploadFiles(IFormCollection form, string username);
        ResumeForGetDto UpdateResume(ResumeForUpdateDto resumeDto);
        bool UpdateStatusForUserGuid(Guid guid, Guid resumeGuid);
    }
}
