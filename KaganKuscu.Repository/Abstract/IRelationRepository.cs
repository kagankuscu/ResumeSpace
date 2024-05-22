namespace KaganKuscu.Repository.Abstract
{
    public interface IRelationRepository<T> where T : class
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Update(T entity);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void Save();
    }
}