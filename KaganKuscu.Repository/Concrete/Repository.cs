using KaganKuscu.DataAccess;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Repository.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly AppDbContext _context;
        private DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            Save();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
            Save();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.Where(x => x.IsDeleted == true);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public IQueryable<T> GetAllDeleted()
        {
            return _dbSet.Where(x => x.IsDeleted == false);
        }

        public IQueryable<T> GetAllDeleted(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(x => x.IsDeleted == false).Where(filter);
        }

        public T? GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public T? GetById(Guid id)
        {
            return _dbSet.FirstOrDefault(x => x.Guid == id);
        }

        public T? GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public void Remove(T entity)
        {
            entity.IsDeleted = true;
            entity.IsActive = false;
            entity.DateModified = DateTime.Now;
            _dbSet.Update(entity);
            Save();
        }

        public void Remove(Guid guid)
        {
            T entity = GetById(guid);
            Remove(entity);
        }

        public void Remove(int id)
        {
            T entity = GetById(id);
            Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                entity.IsDeleted = true;
                entity.IsActive = false;
                entity.DateModified = DateTime.Now;
            }
            _dbSet.UpdateRange(entities);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            entity.DateModified = DateTime.Now;
            _dbSet.Update(entity);
            Save();
        }
    }
}
