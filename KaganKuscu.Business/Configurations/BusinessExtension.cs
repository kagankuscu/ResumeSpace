using KaganKuscu.Business.Abstract;
using KaganKuscu.Business.Concrete;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using KaganKuscu.Repository.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Business.Configurations
{
    public static class BusinessExtension
    {
        /// <summary>
        /// Register to IOC All Services
        /// </summary>
        public static void AddBusinessDI(this IServiceCollection service)
        {   
            // Get current assembly types
            // filtering not is abstract and not intercase
            // checking is generic type and generic type definition equel to typeof IBaseService<> we don't include it.
            // we dont need to register IBaseService<>
            var types = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => !x.IsAbstract && !x.IsInterface && x.GetInterfaces()
                    .Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IBaseService<>)));
                
            foreach(var type in types)
            {
                var interfaceService = type
                    .GetInterfaces()
                    .FirstOrDefault();

                    if(interfaceService is not null)
                        service.AddScoped(interfaceService, type);
            }

            // service.AddScoped<IPersonService, PersonService>();
            // service.AddScoped<IQuoteService, QuoteService>();
        }

        /// <summary>
        /// Register to IOC All Repository
        /// </summary>
        public static void AddRepositoryDI(this IServiceCollection service)
        {

            // Get assembly types from BaseModel
            // checking is assignableto Basemodel
            // filtering not is abstract and class
            // checking is generic type and generic type definition equel to typeof IBaseService<> we don't include it.
            // we dont need to register IBaseService<>
            IEnumerable<Type> types = Assembly.GetAssembly(typeof(BaseModel))!
                .GetTypes()
                .Where(x => x.IsAssignableTo(typeof(BaseModel)))
                .Where(x => x.IsClass && !x.IsAbstract)
                .Where(x => !x.FullName!.Equals("KaganKuscu.Model.Models.BaseModel"));

            foreach (var t in types)
            {
                Type interfaceRepositoryType = typeof(IRepository<>).MakeGenericType(t);
                Type repositoryType = typeof(Repository<>).MakeGenericType(t);

                service.AddScoped(interfaceRepositoryType, repositoryType);
            }

            // This is old vesion we should write every model repository for register
            #region OldRegistration
            // service.AddScoped<IRepository<Author>, Repository<Author>>();
            // service.AddScoped<IRepository<Blog>, Repository<Blog>>();
            // service.AddScoped<IRepository<Comment>, Repository<Comment>>();
            // service.AddScoped<IRepository<Person>, Repository<Person>>();
            // service.AddScoped<IRepository<Education>, Repository<Education>>();
            // service.AddScoped<IRepository<Photo>, Repository<Photo>>();
            // service.AddScoped<IRepository<Quote>, Repository<Quote>>();
            // service.AddScoped<IRepository<Reference>, Repository<Reference>>();
            // service.AddScoped<IRepository<Skill>, Repository<Skill>>();
            // service.AddScoped<IRepository<SocialMedia>, Repository<SocialMedia>>();
            // service.AddScoped<IRepository<Tag>, Repository<Tag>>();
            // service.AddScoped<IRepository<WorkExperience>, Repository<WorkExperience>>();
            #endregion
        }
    }
}
