using KaganKuscu.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Business.Abstract
{
    public interface IBaseService<T> where T : BaseModel
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        IQueryable<T> GetAll();
        T GetById(int id);
        T GetById(Guid guid);

        void Remove(T entity);
        void Remove(int id);
        void Remove(Guid guid);

        void Update(T entity);
        void Update(Guid guid);
        void Update(int id);
    }
}
