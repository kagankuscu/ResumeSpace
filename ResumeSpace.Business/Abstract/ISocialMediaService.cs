using ResumeSpace.Model.SocialMediaDto;

namespace ResumeSpace.Business.Abstract
{
    public interface ISocialMediaService
    {
        List<SocialMediaForGetWithResumesDto> GetAllSocialMediaWithResumes();
        List<SocialMediaForGetWithResumesDto> GetAllSocialMediaWithResumes(Guid userId);
        SocialMediaForGetWithResumesDto AddSocialMedia(SocialMediaForAddDto educationDto);
        void RemoveSocialMedia(Guid guid);
        SocialMediaForGetWithResumesDto UpdateSocialMedia(SocialMediaForUpdateDto educationDto);
        bool ToggleStatus(Guid guid);
    }
}