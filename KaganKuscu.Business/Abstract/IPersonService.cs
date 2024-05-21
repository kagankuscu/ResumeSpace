using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Dtos.PersonDto;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Http;

namespace KaganKuscu.Business.Abstract
{
    public interface IPersonService : IBaseService<Person>
    {
        IQueryable<PersonForGetDto> GetAllPersonDto();
        IQueryable<PersonForAppUserDto> GetAllByAppUserGuid(Guid guid);
        Task<bool> UploadFiles(IFormCollection form, string username, Person person);
        bool UpdateIsActiveForUser(Guid guid);
    }
}
