using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Model.SocialMediaDto;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Business.Concrete
{
    public class SocialMediaService : ISocialMediaService
    {
        public readonly IRepository<SocialMedia> _repository;
        private readonly IResumeService _resumeService;
        public readonly IMapper _mapper;

        public SocialMediaService(IRepository<SocialMedia> repository, IMapper mapper, IResumeService resumeService)
        {
            _repository = repository;
            _mapper = mapper;
            _resumeService = resumeService;
        }

        public void Add(SocialMedia entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<SocialMedia> entities)
        {
        }

        public SocialMediaForGetWithResumesDto AddSocialMedia(SocialMediaForAddDto socialMediaDto)
        {
            SocialMedia reference = _mapper.Map<SocialMedia>(socialMediaDto);
            _repository.Add(reference);
            SocialMediaForGetWithResumesDto returnData = _mapper.Map<SocialMediaForGetWithResumesDto>(reference);
            returnData.Resumes = _mapper.Map<List<ResumeForGetDto>>(_resumeService.GetAll().Where(r => r.ResumesSocialMedias.Any(re => re.SocialMediaId == reference.Id)).ToList());
            return returnData;
        }

        public IQueryable<SocialMedia> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SocialMediaForGetDto> GetAllSocialMedia()
        {
            List<SocialMedia> socialMedias = _repository.GetAll().ToList();

            return _mapper.Map<List<SocialMediaForGetDto>>(socialMedias);
        }

        public List<SocialMediaForGetWithResumesDto> GetAllSocialMediaWithResumes()
        {
            List<SocialMediaForGetWithResumesDto> socialMedias = _repository.GetAll()
              .Select(e => new SocialMediaForGetWithResumesDto
              {
                  Guid = e.Guid,
                  Name = e.Name,
                  Url = e.Url,
                  IconCssClass = e.IconCssClass,
                  IsActive = e.IsActive,
                  Resumes = _mapper.Map<List<ResumeForGetDto>>(e.ResumesSocialMedias.Select(re => re.Resume).ToList())
              }).ToList();

            return socialMedias;
        }

        public List<SocialMediaForGetWithResumesDto> GetAllSocialMediaWithResumes(Guid userId)
        {
            List<SocialMediaForGetWithResumesDto> socialMedias = _repository.GetAll()
              .Where(e => e.AppUserId == userId)
              .Select(e => new SocialMediaForGetWithResumesDto
              {
                  Guid = e.Guid,
                  Name = e.Name,
                  Url = e.Url,
                  IconCssClass = e.IconCssClass,
                  IsActive = e.IsActive,
                  Resumes = _mapper.Map<List<ResumeForGetDto>>(e.ResumesSocialMedias.Select(re => re.Resume).ToList())
              }).ToList();

            return socialMedias;
        }

        public SocialMedia? GetById(int id)
        {
            return _repository.GetById(id);
        }

        public SocialMedia? GetById(Guid guid)
        {
            return _repository.GetAll(r => r.Guid == guid).FirstOrDefault();
        }

        public void Remove(SocialMedia entity)
        {
            _repository.Remove(entity);
        }

        public void Remove(int id)
        {
            SocialMedia? socialMedia = _repository.GetAll(e => e.Id == id).SingleOrDefault();
            if (socialMedia is null)
                return;

            Remove(socialMedia);
        }

        public void Remove(Guid guid)
        {
            SocialMedia? socialMedia = _repository.GetAll(e => e.Guid == guid).SingleOrDefault();
            if (socialMedia is null)
                return;

            Remove(socialMedia);
        }

        public bool ToggleStatus(Guid guid)
        {
            SocialMedia? socialMedia = _repository.GetById(guid);
            if (socialMedia is null)
                return false;

            socialMedia.IsActive = !socialMedia.IsActive;
            _repository.Update(socialMedia);
            return true;
        }

        public void Update(SocialMedia entity)
        {
            _repository.Update(entity);
        }

        public void Update(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public SocialMediaForGetWithResumesDto UpdateSocialMedia(SocialMediaForUpdateDto socialMediaDto)
        {
            SocialMedia? socialMedia = _repository.GetAll(e => e.Guid == socialMediaDto.Guid).Include(e => e.ResumesSocialMedias).FirstOrDefault();

            if (socialMedia is null)
                return new SocialMediaForGetWithResumesDto();

            socialMedia.ResumesSocialMedias.Clear();

            foreach (var item in socialMediaDto.ResumesSocialMedias)
            {
                if (!socialMedia.ResumesSocialMedias.Select(re => re.ResumeId).Contains(item.ResumeId))
                    socialMedia.ResumesSocialMedias.Add(item);
            }

            socialMedia.Name = socialMediaDto.Name;
            socialMedia.Url = socialMediaDto.Url;
            socialMedia.IconCssClass = socialMediaDto.IconCssClass;
            socialMedia.IsActive = socialMediaDto.IsActive;
            Update(socialMedia);

            var returnDto = _mapper.Map<SocialMediaForGetWithResumesDto>(socialMediaDto);
            returnDto.Resumes = _mapper.Map<List<ResumeForGetDto>>(_resumeService.GetAll().Where(r => r.ResumesSocialMedias.Any(re => re.SocialMediaId == socialMedia.Id)).ToList());
            return returnDto;
        }
    }
}