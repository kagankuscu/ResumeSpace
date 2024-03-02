using KaganKuscu.Business.Abstract;
using KaganKuscu.Business.Concrete;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using KaganKuscu.Repository.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Business.Configurations
{
    public static class BusinessExtension
    {
        public static void AddBusinessDI(this IServiceCollection service)
        {
            service.AddScoped<IPersonService, PersonService>();
        }
        public static void AddRepositoryDI(this IServiceCollection service)
        {
            service.AddScoped<IRepository<Author>, Repository<Author>>();
            service.AddScoped<IRepository<Blog>, Repository<Blog>>();
            service.AddScoped<IRepository<Comment>, Repository<Comment>>();
            service.AddScoped<IRepository<Education>, Repository<Education>>();
            service.AddScoped<IRepository<Person>, Repository<Person>>();
            service.AddScoped<IRepository<Photo>, Repository<Photo>>();
            service.AddScoped<IRepository<Quote>, Repository<Quote>>();
            service.AddScoped<IRepository<Reference>, Repository<Reference>>();
            service.AddScoped<IRepository<Skill>, Repository<Skill>>();
            service.AddScoped<IRepository<SocialMedia>, Repository<SocialMedia>>();
            service.AddScoped<IRepository<Tag>, Repository<Tag>>();
            service.AddScoped<IRepository<WorkExperience>, Repository<WorkExperience>>();
        }
    }
}
