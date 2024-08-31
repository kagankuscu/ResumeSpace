using ResumeSpace.Model.SocialMediaDto;

namespace ResumeSpace.Business.Abstract;

public interface ISocialMediaIconService
{
    List<SocialMediaIconForGetDto> GetAllSocialMediaIcon();
}
