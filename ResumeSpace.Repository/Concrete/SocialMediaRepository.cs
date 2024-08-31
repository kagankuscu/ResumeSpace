using ResumeSpace.DataAccess;
using ResumeSpace.Model.Models;
using ResumeSpace.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ResumeSpace.Repository.Concrete;

public class SocialMediaRepository : Repository<SocialMedia>, ISocialMediaRepository
{
    public SocialMediaRepository(AppDbContext context) : base(context)
    {
    }

    public SocialMedia? AddSocialMedia(SocialMedia socialMedia)
    {
        Add(socialMedia);
        return GetAllSocialMediaWithResumes().Where(x => x.Id == socialMedia.Id).FirstOrDefault();
    }

    public IQueryable<SocialMedia> GetAllSocialMediaWithResumes() => GetAll().Include(x => x.ResumesSocialMedias).ThenInclude(x => x.Resume).Include(x => x.SocialMediaIcon);

    public IQueryable<SocialMedia> GetAllSocialMediaWithResumes(Guid userId) => GetAll().Where(x => x.AppUserId == userId).Include(x => x.ResumesSocialMedias).ThenInclude(x => x.Resume).Include(x => x.SocialMediaIcon);

    public void RemoveSocialMedia(Guid guid) => Remove(guid);

    public bool ToggleStatus(Guid guid)
    {
        SocialMedia? socialMedia = GetById(guid);
        if (socialMedia is null)
            return false;

        socialMedia.IsActive = !socialMedia.IsActive;
        Update(socialMedia);
        return true;
    }

    public SocialMedia? UpdateSocialMedia(SocialMedia socialMedia)
    {
        Update(socialMedia);
        return GetAllSocialMediaWithResumes().Where(x => x.Guid == socialMedia.Guid).FirstOrDefault();

    }
}
