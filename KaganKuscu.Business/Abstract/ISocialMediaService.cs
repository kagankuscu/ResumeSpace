using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaganKuscu.Model.Models;
using KaganKuscu.Model.SocialMediaDto;

namespace KaganKuscu.Business.Abstract
{
    public interface ISocialMediaService : IBaseService<SocialMedia>
    {
        List<SocialMediaForGetDto> GetAllSocialMedia();
        List<SocialMediaForGetWithResumesDto> GetAllSocialMediaWithResumes();
        List<SocialMediaForGetWithResumesDto> GetAllSocialMediaWithResumes(Guid userId);
        SocialMediaForGetWithResumesDto AddSocialMedia(SocialMediaForAddDto educationDto);
        SocialMediaForGetWithResumesDto UpdateSocialMedia(SocialMediaForUpdateDto educationDto);
        bool ToggleStatus(Guid guid);
    }
}