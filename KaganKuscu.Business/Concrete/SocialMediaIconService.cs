using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;

namespace KaganKuscu.Business;

public class SocialMediaIconService : ISocialMediaIconService
{
    private readonly IRepository<SocialMediaIcon> _repository;

    public SocialMediaIconService(IRepository<SocialMediaIcon> repository)
    {
        _repository = repository;
    }

    public void Add(SocialMediaIcon entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<SocialMediaIcon> entities)
    {
        throw new NotImplementedException();
    }

    public IQueryable<SocialMediaIcon> GetAll()
    {
        return _repository.GetAll();        
    }

    public SocialMediaIcon? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public SocialMediaIcon? GetById(Guid guid)
    {
        throw new NotImplementedException();
    }

    public void Remove(SocialMediaIcon entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(Guid guid)
    {
        throw new NotImplementedException();
    }

    public void Update(SocialMediaIcon entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Guid guid)
    {
        throw new NotImplementedException();
    }

    public void Update(int id)
    {
        throw new NotImplementedException();
    }
}
