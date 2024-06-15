using KaganKuscu.Model.Models;

namespace KaganKuscu.Repository.Abstract;

public interface ISocialMediaIconRepository : IRepository<SocialMediaIcon>
{
    IQueryable<SocialMediaIcon> GetAllSocialMediaIcon();
}
