using KaganKuscu.Model.Dtos.QuoteDto;

namespace KaganKuscu.Business.Abstract
{
    public interface IQuoteService
    {
        QuoteForGetDto AddQuote(QuoteForAddDto quoteDto);
        ICollection<QuoteForGetDto> GetAllQuote();
        QuoteForGetDto GetRandomQuote();
        QuoteForGetDto UpdateQuote(QuoteForUpdateDto quoteDto);
        void RemoveQuote(Guid guid);
    }
}
