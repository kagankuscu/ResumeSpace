using KaganKuscu.Model.Models;

namespace KaganKuscu.Repository.Abstract;

public interface ISocialMediaIconRepository
{
    IQueryable<SocialMediaIcon> GetAllSocialMediaIcon();
}
