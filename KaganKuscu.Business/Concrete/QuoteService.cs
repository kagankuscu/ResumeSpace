using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Business.Concrete
{
    public class QuoteService : IQuoteService
    {
        private readonly IRepository<Quote> _repository;

        public QuoteService(IRepository<Quote> repository)
        {
            _repository = repository;
        }

        public void Add(Quote entity)
        {
            _repository.Add(entity);
        }

        public void AddRange(IEnumerable<Quote> entities)
        {
            _repository.AddRange(entities);
        }

        public IQueryable<Quote> GetAll()
        {
            return _repository.GetAll();
        }

        public Quote GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Quote GetById(Guid guid)
        {
            return _repository.GetById(guid);
        }

        public Quote GetRandomQuote()
        {
            return _repository.GetAll().OrderBy(x => Guid.NewGuid()).First();
        }

        public ICollection<Quote> GetRandomQuotes(int limit)
        {
            return _repository.GetAll().OrderBy(x => Guid.NewGuid()).Take(limit).ToList();
        }

        public void Remove(Quote entity)
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

        public void Update(Quote entity)
        {
            _repository.Update(entity);
        }

        public void Update(Guid guid)
        {
            Quote real = GetById(guid);
            Update(real);
        }

        public void Update(int id)
        {
            Update(GetById(id));
        }
    }
}
