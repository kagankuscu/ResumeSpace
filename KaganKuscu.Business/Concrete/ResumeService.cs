using System.ComponentModel.DataAnnotations;
using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Model.SocialMediaDto;
using KaganKuscu.Repository.Abstract;
using KaganKuscu.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace KaganKuscu.Business.Concrete
{
    public class ResumeService : IResumeService
    {
        private readonly IResumeRepository _repository;
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public ResumeService(IResumeRepository repository, IMapper mapper, ISocialMediaService socialMediaService)
        {
            _repository = repository;
            _mapper = mapper;
            _socialMediaService = socialMediaService;
        }

        public ICollection<ResumeForAppUserDto> GetAllByAppUserGuid(Guid guid)
        {
            return _mapper.Map<List<ResumeForAppUserDto>>(_repository.GetAllByAppUserGuid(guid));
        }

        public bool UpdateStatusForUserGuid(Guid guid) => _repository.UpdateStatusForUserGuid(guid);

        public async Task<bool> UploadFiles(IFormCollection form, string username, Resume resume)
        {
            // wwwroot/img/resumes/<username>/<imagename>
            // wwwroot/Files/Resume/<username>/<resumename>
            IFormFile? image = form.Files["image"];
            IFormFile? resumeFile = form.Files["resume"];

            string imageFilename;
            string resumeFilename;
            Resume? real = _repository.GetById(resume.Guid);
            if (real is null)
                return false;

            if (image is not null)
            {
                string serverImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "resumes", username);

                if (!Directory.Exists(serverImagePath))
                    Directory.CreateDirectory(serverImagePath);

                imageFilename = Helper.RandomStringGenerator(3) + "-" + username + Path.GetExtension(image.FileName);

                string imagePath = Path.Combine(serverImagePath, imageFilename);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                real.ImagePath = $"{username}/{imageFilename}";
            }

            if (resumeFile is not null)
            {
                string serverResumePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files", "Resume", username);

                if (!Directory.Exists(serverResumePath))
                    Directory.CreateDirectory(serverResumePath);

                resumeFilename = Helper.RandomStringGenerator(3) + "-" + username + Path.GetExtension(resumeFile.FileName);

                string resumePath = Path.Combine(serverResumePath, resumeFilename);

                using (var stream = new FileStream(resumePath, FileMode.Create))
                {
                    await resumeFile.CopyToAsync(stream);
                }

                real.ResumePath = $"{username}/{resumeFilename}";
            }

            try
            {
                real.SecondPhone = resume.SecondPhone;
                real.Interest = resume.Interest;

                _repository.Update(real);
                _repository.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ResumeForGetDto UpdateResume(ResumeForUpdateDto resumeDto)
        {
            Resume? real = _repository.GetAll(x => x.Guid == resumeDto.Guid).FirstOrDefault();
            return _mapper.Map<ResumeForGetDto>(_repository.UpdateResume(_mapper.Map(resumeDto, real)));
        }

        public bool ToggleStatus(Guid guid) => _repository.ToggleStatus(guid);

        public ResumeForGetDto AddResume(ResumeForAddDto resumeDto)
        {
            Resume resume = _mapper.Map<Resume>(resumeDto);
            return _mapper.Map<ResumeForGetDto>(_repository.AddResume(resume));
        }

        public void RemoveResume(Guid guid) => RemoveResume(guid);

        public ICollection<ResumeForGetWithDetailsDto> GetAllResumeDto()
        {
            var resumes = _repository.GetAllResumeWithDetail();

            return _mapper.Map<List<ResumeForGetWithDetailsDto>>(resumes);
        }
    }
}