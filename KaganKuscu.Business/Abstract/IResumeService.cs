using System.Linq.Expressions;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Http;

namespace KaganKuscu.Business.Abstract
{
    public interface IResumeService : IBaseService<Resume>
    {
        IQueryable<ResumeForGetWithDetailsDto> GetAllResumeDto();
        IQueryable<ResumeForAppUserDto> GetAllByAppUserGuid(Guid guid);
        Task<bool> UploadFiles(IFormCollection form, string username, Resume resume);
        bool UpdateIsActiveForUser(Guid guid);
        IQueryable<ResumeForGetDto> GetAllResume();
        IQueryable<ResumeForGetDto> GetAllResume(Expression<Func<ResumeForGetDto, bool>> predicate);
        IQueryable<ResumeForGetDto> GetAllResumeBySkillId(int id);
    }
}
