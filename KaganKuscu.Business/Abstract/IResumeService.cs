using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Dtos.ResumeDto;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Http;

namespace KaganKuscu.Business.Abstract
{
    public interface IResumeService : IBaseService<Resume>
    {
        IQueryable<ResumeForGetDto> GetAllResumeDto();
        IQueryable<ResumeForAppUserDto> GetAllByAppUserGuid(Guid guid);
        Task<bool> UploadFiles(IFormCollection form, string username, Resume resume);
        bool UpdateIsActiveForUser(Guid guid);
    }
}
