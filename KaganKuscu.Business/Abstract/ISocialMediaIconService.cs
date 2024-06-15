using KaganKuscu.Model.SocialMediaDto;

namespace KaganKuscu.Business.Abstract;

public interface ISocialMediaIconService
{
    List<SocialMediaIconForGetDto> GetAllSocialMediaIcon();
}
