using KaganKuscu.Business.Abstract;
using KaganKuscu.DataAccess;
using KaganKuscu.Model.Dtos;
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
                .Include(p => p.References);
        }
        public IQueryable<PersonDto> GetAllPersonDto()
        {
            return _repository.GetAll()
                .Include(p => p.SocialMedias)
                .Include(p => p.Skills)
                .Include(p => p.WorkExperiences)
                .Include(p => p.Educations)
                .Include(p => p.References)
                .Select(p => new PersonDto
                {
                    Name = p.Name,
                    Age = Convert.ToInt32((DateTime.Now - p.BirthDate).TotalDays / 365.2465),
                    Address = p.Address,
                    Title = p.Title,
                    Phone = p.Phone,
                    ImagePath = p.ImagePath,
                    ResumePath = p.ResumePath,
                    Description = p.Description,
                    References = p.References.ToList(),
                    Skills = p.Skills.ToList(),
                    SocialMedias = p.SocialMedias.ToList(),
                    Educations = p.Educations.OrderByDescending(e => e.StartDate).ToList(),
                    WorkExperiences = p.WorkExperiences.OrderByDescending(e => e.StartDate).ToList()
                });
        }
        public Person GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Person GetById(Guid guid)
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
            Person real = GetById(entity.Id);
            real.Address = entity.Address;
            real.BirthDate = entity.BirthDate;
            real.Description = entity.Description;
        }

        public void Update(Guid guid)
        {
            Person real = GetById(guid);
            Update(real);
        }

        public void Update(int id)
        {
            Person real = GetById(id);
            Update(real);
        }
    }
}
