using AutoMapper;
using ResumeSpace.Business.Abstract;
using ResumeSpace.Model.Dtos.QuoteDto;
using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Abstract;

namespace ResumeSpace.Business.Concrete
{
    public class QuoteService : IQuoteService
    {
        private readonly IQuoteRepository _repository;
        private readonly IMapper _mapper;

        public QuoteService(IMapper mapper, IQuoteRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public QuoteForGetDto AddQuote(QuoteForAddDto quoteDto)
        {
            Quote quote = _mapper.Map<Quote>(quoteDto);
            return _mapper.Map<QuoteForGetDto>(quote);
        }

        public ICollection<QuoteForGetDto> GetAllQuote() => _mapper.Map<List<QuoteForGetDto>>(_repository.GetAllQuote());

        public QuoteForGetDto GetRandomQuote() => _mapper.Map<QuoteForGetDto>(_repository.GetRandomQuote());

        public void RemoveQuote(Guid guid) => _repository.RemoveQuote(guid);

        public QuoteForGetDto UpdateQuote(QuoteForUpdateDto quoteDto)
        {
            Quote quote = _mapper.Map<Quote>(quoteDto);
            _repository.UpdateQuote(quote);
            return _mapper.Map<QuoteForGetDto>(quote);
        }
    }
}
