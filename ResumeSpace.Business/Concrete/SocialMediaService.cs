using AutoMapper;
using ResumeSpace.Business.Abstract;
using ResumeSpace.Model.Dtos.ResumesDto;
using ResumeSpace.Model.Models;
using ResumeSpace.Model.SocialMediaDto;
using ResumeSpace.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ResumeSpace.Business.Concrete
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

        public void RemoveSocialMedia(Guid guid)
        {
            _repository.RemoveSocialMedia(guid);
        }

        public bool ToggleStatus(Guid guid) => _repository.ToggleStatus(guid);

        public SocialMediaForGetWithResumesDto UpdateSocialMedia(SocialMediaForUpdateDto socialMediaDto)
        {
            SocialMedia real = _repository.GetAll(x => x.Guid == socialMediaDto.Guid).Include(x => x.ResumesSocialMedias).FirstOrDefault();
            foreach (var item in real.ResumesSocialMedias)
            {
                if (socialMediaDto.ResumesSocialMedias.Select(re => re.ResumeId).Contains(item.ResumeId))
                    socialMediaDto.ResumesSocialMedias.Remove(item);
            }
            return _mapper.Map<SocialMediaForGetWithResumesDto>(_repository.UpdateSocialMedia(_mapper.Map(socialMediaDto, real)));
        }
    }
}