using KaganKuscu.Business.Abstract;
using KaganKuscu.DataAccess;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Business.Concrete
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _repository;

        public PersonService(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public void Add(Person entity)
        {
            _repository.Add(entity);
        }

        public void AddRange(IEnumerable<Person> entities)
        {
            _repository.AddRange(entities);
        }

        public IQueryable<Person> GetAll()
        {
            return _repository.GetAll();
        }

        public Person GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Person GetById(Guid guid)
        {
            return _repository.GetById(guid);
        }

        public void Remove(Person entity)
        {
            _repository.Remove(entity);
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Remove(Guid guid)
        {
            _repository.Remove(guid);
        }

        public void Update(Person entity)
        {
            Person real = GetById(entity.Id);
            real.Address = entity.Address;
            real.BirthDate = entity.BirthDate;
            real.Description = entity.Description;
        }

        public void Update(Guid guid)
        {
            Person real = GetById(guid);
            Update(real);
        }

        public void Update(int id)
        {
            Person real = GetById(id);
            Update(real);
        }
    }
}
