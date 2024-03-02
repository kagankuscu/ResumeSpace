using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Business.Abstract
{
    public interface IPersonService : IBaseService<Person>
    {
        IQueryable<PersonDto> GetAllPersonDto();
    }
}
