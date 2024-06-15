using KaganKuscu.DataAccess;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Repository.Concrete;

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
        SocialMedia? real = GetAllSocialMediaWithResumes().Where(x => x.Guid == socialMedia.Guid).FirstOrDefault(); 

        if (real is null)
            return null;

        real.ResumesSocialMedias.Clear();

        foreach (var item in socialMedia.ResumesSocialMedias)
        {
            if (!real.ResumesSocialMedias.Select(re => re.ResumeId).Contains(item.ResumeId))
                real.ResumesSocialMedias.Add(item);
        }

        real.Url = socialMedia.Url;
        real.SocialMediaIconId = socialMedia.SocialMediaIconId;
        real.IsActive = socialMedia.IsActive;
        Update(real);

        return GetAllSocialMediaWithResumes().Where(x => x.Guid == real.Guid).FirstOrDefault();

    }
}
