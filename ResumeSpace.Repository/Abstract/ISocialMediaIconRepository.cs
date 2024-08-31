using ResumeSpace.Model.Models;

namespace ResumeSpace.Repository.Abstract;

public interface ISocialMediaIconRepository : IRepository<SocialMediaIcon>
{
    IQueryable<SocialMediaIcon> GetAllSocialMediaIcon();
}
