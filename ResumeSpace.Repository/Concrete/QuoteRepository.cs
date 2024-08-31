using ResumeSpace.DataAccess;
using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Abstract;

namespace ResumeSpace.Repository.Concrete;

public class QuoteRepository : Repository<Quote>, IQuoteRepository
{
    public QuoteRepository(AppDbContext context) : base(context)
    {
    }

    public Quote AddQuote(Quote quote)
    {
        AddQuote(quote);
        return quote;
    }

    public IQueryable<Quote> GetAllQuote() => GetAll();

    public Quote GetRandomQuote() => GetAll().OrderBy(x => Guid.NewGuid()).First();

    public void RemoveQuote(Guid guid) => Remove(guid);

    public Quote? UpdateQuote(Quote quote)
    {
        Quote? real = GetById(quote.Guid);
        if (real is null)
            return null;
        real.Owner = quote.Owner;
        real.Content = quote.Content;
        Update(quote);
        return quote; 
    }
}
