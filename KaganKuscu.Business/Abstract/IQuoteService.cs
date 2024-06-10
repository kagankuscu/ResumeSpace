using KaganKuscu.Model;
using KaganKuscu.Model.Dtos.QuoteDto;
using KaganKuscu.Model.Models;

namespace KaganKuscu.Business.Abstract
{
    public interface IQuoteService : IBaseService<Quote>
    {
        QuoteForGetDto GetRandomQuote();
        ICollection<QuoteForGetDto> GetAllQuote();
        ICollection<QuoteForGetDto> GetRandomQuotes(int limit);
        QuoteForGetDto AddQuote(QuoteForAddDto quoteDto);
        QuoteForGetDto UpdateQuote(QuoteForUpdateDto quoteDto);
    }
}
