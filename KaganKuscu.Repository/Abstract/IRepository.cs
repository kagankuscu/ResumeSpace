using KaganKuscu.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Repository.Abstract
{
    public interface IRepository<T> where T : BaseModel
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Update(T entity);

        void Remove(T entity);
        void Remove(Guid guid);
        void Remove(int id);
        void RemoveRange(IEnumerable<T> entities);

        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAllDeleted();
        IQueryable<T> GetAllDeleted(Expression<Func<T, bool>> filter);
        T? GetById(int id);
        T? GetById(Guid id);
        T? GetFirstOrDefault(Expression<Func<T, bool>> predicate);

        void Save();
    }
}
