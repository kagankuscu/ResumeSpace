using ResumeSpace.DataAccess;
using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Abstract;

namespace ResumeSpace.Repository.Concrete;

public class SocialMediaIconRepository : Repository<SocialMediaIcon>, ISocialMediaIconRepository
{
    public SocialMediaIconRepository(AppDbContext context) : base(context)
    {
    }

    public IQueryable<SocialMediaIcon> GetAllSocialMediaIcon() => GetAll();
}
