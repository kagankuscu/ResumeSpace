﻿using AutoMapper;
using ResumeSpace.Business.Abstract;
using ResumeSpace.Model.Dtos.ResumesDto;
using ResumeSpace.Model.Models;
using ResumeSpace.Model.Rel;
using ResumeSpace.Repository.Abstract;
using ResumeSpace.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ResumeSpace.Business.Concrete
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

        public async Task<ResumeForGetDto> UploadFiles(IFormCollection form, string username)
        {
            // wwwroot/img/resumes/<username>/<imagename>
            // wwwroot/Files/Resume/<username>/<resumename>
            IFormFile? image = form.Files["image"];
            IFormFile? resumeFile = form.Files["resume"];

            string imageFilename;
            string resumeFilename;
            Resume? real = _repository.GetById(Guid.Parse(form["guid"]!));
            if (real is null)
                throw new Exception($"Resume cannot found. {form["guid"]}");

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
                real.SecondPhone = form["secondPhone"];
                real.Interest = form["interest"];

                _repository.Update(real);
                _repository.Save();
                return _mapper.Map<ResumeForGetDto>(real);
            }
            catch
            {
                throw new Exception("Something went wrong saving");
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

        public void RemoveResume(Guid guid) => _repository.RemoveResume(guid);

        public ICollection<ResumeForAppUserDto> GetAllResumeDto()
        {
            var resumes = _repository.GetAllResumeWithDetail();

            return _mapper.Map<List<ResumeForAppUserDto>>(resumes);
        }

        public bool UpdateStatusForUserGuid(Guid guid, Guid resumeGuid) => _repository.UpdateStatusForUserGuid(guid, resumeGuid);

        public ResumeForGetWithDetailsDto GetResumeWithDetailslByUsername(string username)
        {
            Resume? resume = _repository.GetAllResume()
                .Include(x => x.AppUser)
                .Include(x => x.ResumesEducations.Where(x => x.Education!.IsActive).OrderByDescending(x => x.Education!.StartDate).ThenBy(x => x.Education!.EndDate))
                    .ThenInclude(e => e.Education)
                .Include(x => x.ResumesSocialMedias.Where(x => x.SocialMedia!.IsActive))
                    .ThenInclude(sm => sm.SocialMedia)
                        .ThenInclude(sm => sm.SocialMediaIcon)
                .Include(x => x.ResumesWorkExperiences.Where(x => x.WorkExperience!.IsActive).OrderByDescending(x => x.WorkExperience!.StartDate).ThenBy(x => x.WorkExperience!.EndDate))
                    .ThenInclude(we => we.WorkExperience)
                .Include(x => x.ResumesReferences.Where(x => x.Reference!.IsActive))
                    .ThenInclude(r => r.Reference)
                .Include(x => x.ResumesSkills.Where(x => x.Skill!.IsActive).OrderByDescending(x => x.Skill!.Percent))
                    .ThenInclude(rs => rs.Skill)
                .Include(x => x.ResumesReferences.Where(x => x.Reference!.IsActive))
                    .ThenInclude(rr => rr.Reference)
                .Include(x => x.Interests)
                .Where(x => x.AppUser!.UserName!.ToLower() == username)
                .Where(x => x.IsActive)
                .FirstOrDefault();

            ResumeForGetWithDetailsDto resumeDto = _mapper.Map<ResumeForGetWithDetailsDto>(resume);
            resumeDto.Age = Utility.CalculateAge(resume!.BirthDate);
            return resumeDto;
        }

        public ICollection<ResumeForGetList> GetAllUsers()
        {
            var resumes = _repository.GetAllResume()
                .Include(x => x.AppUser)
                .Where(x => x.IsActive)
                .OrderBy(x => Guid.NewGuid())
                .ToList();
            return _mapper.Map<List<ResumeForGetList>>(resumes);
        }
    }
}
