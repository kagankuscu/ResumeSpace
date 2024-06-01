using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using KaganKuscu.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KaganKuscu.Business.Concrete
{
    public class ResumeService : IResumeService
    {
        private readonly IRepository<Resume> _repository;

        public ResumeService(IRepository<Resume> repository)
        {
            _repository = repository;
        }

        public void Add(Resume entity)
        {
            _repository.Add(entity);
        }

        public void AddRange(IEnumerable<Resume> entities)
        {
            _repository.AddRange(entities);
        }

        public IQueryable<ResumeForGetDto> GetAllResume()
        {
          return _repository.GetAll().Select(r => new ResumeForGetDto
              {
                ResumeName = r.ResumeName,
                FullName = r.FullName,
                BirthDate = r.BirthDate,
                Address = r.Address,
                Email = r.Email,
                Phone = r.Phone,
                SecondPhone = r.SecondPhone,
                About = r.About,
                Title = r.Title,
                ImagePath = r.ImagePath,
                ResumePath = r.ResumePath,
                Interest = r.Interest,
                AppUserId = r.AppUserId
              });
        }

        public IQueryable<ResumeForGetDto> GetAllResume(Expression<Func<ResumeForGetDto, bool>> predicate)
        {
          return _repository.GetAll().Select(r => new ResumeForGetDto 
              {
                ResumeName = r.ResumeName,
                FullName = r.FullName,
                BirthDate = r.BirthDate,
                Address = r.Address,
                Email = r.Email,
                Phone = r.Phone,
                SecondPhone = r.SecondPhone,
                About = r.About,
                Title = r.Title,
                ImagePath = r.ImagePath,
                ResumePath = r.ResumePath,
                Interest = r.Interest,
                AppUserId = r.AppUserId
              });
        }

        public IQueryable<ResumeForGetDto> GetAllResumeBySkillId(int id)
        {
          return _repository
            .GetAll()
            .Include(r => r.ResumesSkills)
            .Select(r => new ResumeForGetDto 
              {
                ResumeName = r.ResumeName,
                FullName = r.FullName,
                BirthDate = r.BirthDate,
                Address = r.Address,
                Email = r.Email,
                Phone = r.Phone,
                SecondPhone = r.SecondPhone,
                About = r.About,
                Title = r.Title,
                ImagePath = r.ImagePath,
                ResumePath = r.ResumePath,
                Interest = r.Interest,
                AppUserId = r.AppUserId
              });

        }

        public IQueryable<Resume> GetAll()
        {
            return _repository.GetAll()
                .Include(p => p.SocialMedias)
                .Include(p => p.References)
                .Include(p => p.Interests);
        }

        public IQueryable<ResumeForAppUserDto> GetAllByAppUserGuid(Guid guid)
        {
            return _repository
                .GetAll(p => p.AppUserId == guid.ToString())
                .Where(p => !p.IsDeleted)
                .Select(p => new ResumeForAppUserDto
                {
                    Id = p.Id,
                    Guid = p.Guid,
                    ResumeName = p.ResumeName,
                    FullName = p.FullName,
                    BirthDate = p.BirthDate,
                    Address = p.Address,
                    Email = p.Email,
                    Phone = p.Phone,
                    SecondPhone = p.SecondPhone,
                    About = p.About ?? string.Empty,
                    Title = p.Title,
                    ImagePath = p.ImagePath,
                    ResumePath = p.ResumePath,
                    Interest = p.Interest,
                    IsActive = p.IsActive,
                    AppUserId = p.AppUserId
                });
        }

        public IQueryable<ResumeForGetWithDetailsDto> GetAllResumeDto()
        {
            return _repository.GetAll()
                .Include(p => p.SocialMedias)
                .Include(p => p.References)
                .Include(p => p.Interests)
                .Select(p => new ResumeForGetWithDetailsDto
                {
                    Name = p.FullName,
                    Age = Convert.ToInt32((DateTime.Now - p.BirthDate).TotalDays / 365.2465),
                    Address = p.Address ?? string.Empty,
                    Title = p.Title,
                    Phone = p.Phone,
                    Email = p.Email,
                    Interest = p.Interest ?? string.Empty,
                    Interests = p.Interests.ToList(),
                    ImagePath = p.ImagePath ?? string.Empty,
                    ResumePath = p.ResumePath ?? string.Empty,
                    Description = p.About ?? string.Empty,
                    References = p.References.ToList(),
                    Skills = p.ResumesSkills!.Select(s => s.Skill!).Where(s => s.IsActive).ToList(),
                    SocialMedias = p.SocialMedias.ToList(),
                    Educations = p.ResumesEducations!.Select(rs => rs.Education!).Where(e => e.IsActive).OrderByDescending(e => e.StartDate).ToList(),
                    WorkExperiences = p.ResumesWorkExperiences.Select(rwe => rwe.WorkExperience!).Where(rwe => rwe.IsActive).OrderByDescending(e => e.StartDate).ToList()
                });
        }
        public Resume? GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Resume? GetById(Guid guid)
        {
            return _repository.GetById(guid);
        }

        public void Remove(Resume entity)
        {
            _repository.Remove(entity);
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Remove(Guid guid)
        {
            _repository.Remove(guid);
        }

        public void Update(Resume entity)
        {
            Resume? real = GetById(entity.Guid);
            if (real is not null)
            {
                // TODO: Use AutoMapper
                real.Email = entity.Email;
                real.FullName = entity.FullName;
                real.Title = entity.Title;
                real.Phone = entity.Phone;
                real.SecondPhone = entity.SecondPhone;
                real.Address = entity.Address;
                real.BirthDate = entity.BirthDate;
                real.About = entity.About;

                _repository.Update(real);
            }
        }

        public void Update(Guid guid)
        {
            Resume? real = GetById(guid);
            if (real is not null)
                Update(real);
        }

        public void Update(int id)
        {
            Resume? real = GetById(id);
            if (real is not null)
                Update(real);
        }

        public bool UpdateIsActiveForUser(Guid guid)
        {
            try
            {
                var resumes = _repository.GetAll(p => p.AppUserId == guid.ToString() && p.IsActive).ToList();
                foreach (Resume resume in resumes)
                {
                    resume.IsActive = false;
                    _repository.Update(resume);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UploadFiles(IFormCollection form, string username, Resume resume)
        {
            // wwwroot/img/resumes/<username>/<imagename>
            // wwwroot/Files/Resume/<username>/<resumename>
            IFormFile? image = form.Files["image"];
            IFormFile? resumeFile = form.Files["resume"];

            string imageFilename;
            string resumeFilename;
            Resume? real = GetById(resume.Guid);
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

    }
}
