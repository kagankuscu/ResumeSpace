using KaganKuscu.DataAccess;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;

namespace KaganKuscu.Repository.Concrete;

public class SocialMediaIconRepository : Repository<SocialMediaIcon>, ISocialMediaIconRepository
{
    public SocialMediaIconRepository(AppDbContext context) : base(context)
    {
    }

    public IQueryable<SocialMediaIcon> GetAllSocialMediaIcon()
    {
        throw new NotImplementedException();
    }
}
