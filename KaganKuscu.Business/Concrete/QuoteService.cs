using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.QuoteDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;

namespace KaganKuscu.Business.Concrete
{
    public class QuoteService : IQuoteService
    {
        private readonly IRepository<Quote> _repository;
        private readonly IMapper _mapper;

        public QuoteService(IRepository<Quote> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Add(Quote entity)
        {
            _repository.Add(entity);
        }

        public QuoteForGetDto AddQuote(QuoteForAddDto quoteDto)
        {
            Quote quote= _mapper.Map<Quote>(quoteDto);
            Add(quote);
            return _mapper.Map<QuoteForGetDto>(quote);
        }
        public void AddRange(IEnumerable<Quote> entities)

        {
            _repository.AddRange(entities);
        }

        public IQueryable<Quote> GetAll()
        {
            return _repository.GetAll();
        }

        public ICollection<QuoteForGetDto> GetAllQuote()
        {
            return _mapper.Map<ICollection<QuoteForGetDto>>(GetAll().ToList());
        }

        public Quote GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Quote GetById(Guid guid)
        {
            return _repository.GetById(guid);
        }

        public QuoteForGetDto GetRandomQuote()
        {
            return _mapper.Map<QuoteForGetDto>(_repository.GetAll().OrderBy(x => Guid.NewGuid()).First());
        }

        public ICollection<QuoteForGetDto> GetRandomQuotes(int limit)
        {
            return _mapper.Map<List<QuoteForGetDto>>(_repository.GetAll().OrderBy(x => Guid.NewGuid()).Take(limit).ToList());
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

        public QuoteForGetDto UpdateQuote(QuoteForUpdateDto quoteDto)
        {
            Quote quote = GetById(quoteDto.Guid); 
            quote.Owner = quoteDto.Owner;
            quote.Content = quoteDto.Content;
            Update(quote);
            return _mapper.Map<QuoteForGetDto>(quote);
        }
    }
}
