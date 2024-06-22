﻿using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using KaganKuscu.Utilities;
using Microsoft.AspNetCore.Http;

namespace KaganKuscu.Business.Concrete
{
    public class ResumeService : IResumeService
    {
        private readonly IResumeRepository _repository;
        private readonly IMapper _mapper;

        public ResumeService(IResumeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IQueryable<ResumeForAppUserDto> GetAllByAppUserGuid(Guid guid)
        {
            return _mapper.Map<IQueryable<ResumeForAppUserDto>>(_repository.GetAllByAppUserGuid(guid));
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

        public ResumeForGetWithDetailsDto AddResume(ResumeForGetWithDetailsDto resumeForAddDto)
        {
            Resume resume = _mapper.Map<Resume>(resumeForAddDto);
            return _mapper.Map<ResumeForGetWithDetailsDto>(_repository.AddResume(resume));
        }

        public ResumeForGetWithDetailsDto UpdateResume(ResumeForUpdateDto resumeDto)
        {
            Resume resume = _mapper.Map<Resume>(resumeDto);
            return _mapper.Map<ResumeForGetWithDetailsDto>(_repository.UpdateResume(resume));
        }

        public bool ToggleStatus(Guid guid) => _repository.ToggleStatus(guid);

        public ResumeForGetWithDetailsDto AddResume(ResumeForAddDto resumeDto)
        {
            throw new NotImplementedException();
        }

        public void RemoveResume(Guid guid) => RemoveResume(guid);
    }
}