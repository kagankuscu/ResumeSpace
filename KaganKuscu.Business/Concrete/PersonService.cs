using KaganKuscu.Business.Abstract;
using KaganKuscu.DataAccess;
using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Dtos.Person;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Business.Concrete
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _repository;

        public PersonService(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public void Add(Person entity)
        {
            _repository.Add(entity);
        }

        public void AddRange(IEnumerable<Person> entities)
        {
            _repository.AddRange(entities);
        }

        public IQueryable<Person> GetAll()
        {
            return _repository.GetAll()
                .Include(p => p.SocialMedias)
                .Include(p => p.Skills)
                .Include(p => p.WorkExperiences)
                .Include(p => p.Educations)
                .Include(p => p.References)
                .Include(p => p.Interests);
        }

        public IQueryable<PersonForAppUserDto> GetAllByAppUserGuid(Guid guid)
        {
            return _repository
                .GetAll(p => p.AppUserId == guid.ToString())
                .Select(p => new PersonForAppUserDto{
                    Guid = p.Guid,
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
                    AppUserId = p.AppUserId
                });
        }

        public IQueryable<PersonDto> GetAllPersonDto()
        {
            return _repository.GetAll()
                .Include(p => p.SocialMedias)
                .Include(p => p.Skills)
                .Include(p => p.WorkExperiences)
                .Include(p => p.Educations)
                .Include(p => p.References)
                .Include(p => p.Interests)
                .Select(p => new PersonDto
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
                    Skills = p.Skills.ToList(),
                    SocialMedias = p.SocialMedias.ToList(),
                    Educations = p.Educations.OrderByDescending(e => e.StartDate).ToList(),
                    WorkExperiences = p.WorkExperiences.OrderByDescending(e => e.StartDate).ToList()
                });
        }
        public Person? GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Person? GetById(Guid guid)
        {
            return _repository.GetById(guid);
        }

        public void Remove(Person entity)
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

        public void Update(Person entity)
        {
            Person? real = GetById(entity.Guid);
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
            Person? real = GetById(guid);
            if (real is not null)
                Update(real);
        }

        public void Update(int id)
        {
            Person? real = GetById(id);
            if (real is not null)
                Update(real);
        }
    }
}
