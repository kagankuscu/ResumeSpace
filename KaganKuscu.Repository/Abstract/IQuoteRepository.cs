﻿using KaganKuscu.Model.Models;

namespace KaganKuscu.Repository.Abstract;

public interface IQuoteRepository : IRepository<Quote>
{
    Quote AddQuote(Quote quote);
    IQueryable<Quote> GetAllQuote();
    Quote GetRandomQuote();
    void RemoveQuote(Guid guid);
    Quote? UpdateQuote(Quote quote);
}
