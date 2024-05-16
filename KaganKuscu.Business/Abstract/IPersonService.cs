using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Dtos.Person;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Http;

namespace KaganKuscu.Business.Abstract
{
    public interface IPersonService : IBaseService<Person>
    {
        IQueryable<PersonDto> GetAllPersonDto();
        IQueryable<PersonForAppUserDto> GetAllByAppUserGuid(Guid guid);
        Task<bool> UploadFiles(IFormCollection form, string username, Person person);
        bool UpdateIsActiveForUser(Guid guid);
    }
}
