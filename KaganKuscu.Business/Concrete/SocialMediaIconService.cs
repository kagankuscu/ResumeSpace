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

    public IQueryable<SocialMediaIcon> GetAll() => _repository.GetAll();        

    public SocialMediaIcon? GetById(int id) => _repository.GetById(id);

    public SocialMediaIcon? GetById(Guid guid) => _repository.GetById(guid);

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
