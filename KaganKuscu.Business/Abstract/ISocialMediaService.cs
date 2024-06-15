using KaganKuscu.Model.SocialMediaDto;

namespace KaganKuscu.Business.Abstract
{
    public interface ISocialMediaService
    {
        List<SocialMediaForGetWithResumesDto> GetAllSocialMediaWithResumes();
        List<SocialMediaForGetWithResumesDto> GetAllSocialMediaWithResumes(Guid userId);
        SocialMediaForGetWithResumesDto AddSocialMedia(SocialMediaForAddDto educationDto);
        SocialMediaForGetWithResumesDto UpdateSocialMedia(SocialMediaForUpdateDto educationDto);
        bool ToggleStatus(Guid guid);
    }
}