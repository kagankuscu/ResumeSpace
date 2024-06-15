using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Models;
using KaganKuscu.Model.SocialMediaDto;
using KaganKuscu.Repository.Abstract;

namespace KaganKuscu.Business.Concrete
{
    public class SocialMediaService : ISocialMediaService
    {
        public readonly ISocialMediaRepository _repository;
        public readonly IMapper _mapper;

        public SocialMediaService(ISocialMediaRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public SocialMediaForGetWithResumesDto AddSocialMedia(SocialMediaForAddDto socialMediaDto)
        {
            SocialMedia socialMedia = _mapper.Map<SocialMedia>(socialMediaDto);
            
            return _mapper.Map<SocialMediaForGetWithResumesDto>(_repository.AddSocialMedia(socialMedia));
        }

        public List<SocialMediaForGetWithResumesDto> GetAllSocialMediaWithResumes()
        {
            IQueryable<SocialMedia> socialMedias = _repository.GetAllSocialMediaWithResumes();
            
            return _mapper.Map<List<SocialMediaForGetWithResumesDto>>(socialMedias);
        }

        public List<SocialMediaForGetWithResumesDto> GetAllSocialMediaWithResumes(Guid userId)
        {
            IQueryable<SocialMedia> socialMedias = _repository.GetAllSocialMediaWithResumes(userId);

            return _mapper.Map<List<SocialMediaForGetWithResumesDto>>(socialMedias);
        }

        public bool ToggleStatus(Guid guid) => _repository.ToggleStatus(guid);

        public SocialMediaForGetWithResumesDto UpdateSocialMedia(SocialMediaForUpdateDto socialMediaDto)
        {
            SocialMedia socialMedia = _mapper.Map<SocialMedia>(socialMediaDto);
            return _mapper.Map<SocialMediaForGetWithResumesDto>(_repository.UpdateSocialMedia(socialMedia));
        }
    }
}