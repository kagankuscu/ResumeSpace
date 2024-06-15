using KaganKuscu.Model.Models;
using KaganKuscu.Model.SocialMediaDto;

namespace KaganKuscu.Repository.Abstract;

public interface ISocialMediaRepository : IRepository<SocialMedia>
{
        SocialMedia? AddSocialMedia(SocialMedia socialMedia);
        IQueryable<SocialMedia> GetAllSocialMediaWithResumes();
        IQueryable<SocialMedia> GetAllSocialMediaWithResumes(Guid userId);
        bool ToggleStatus(Guid guid);
        SocialMedia? UpdateSocialMedia(SocialMedia socialMedia);
}
