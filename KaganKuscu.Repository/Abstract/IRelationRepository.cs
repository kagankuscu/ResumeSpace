using System.Linq.Expressions;
using KaganKuscu.Model.ManyToMany;

namespace KaganKuscu.Repository.Abstract
{
    public interface IRelationRepository<T> where T : class
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        List<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);

        void Update(T entity);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void Save();
    }
}