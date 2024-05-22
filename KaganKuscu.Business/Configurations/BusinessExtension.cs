using KaganKuscu.Business.Abstract;
using KaganKuscu.Business.Concrete;
using KaganKuscu.Model;
using KaganKuscu.Model.ManyToMany;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using KaganKuscu.Repository.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

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

            service.AddScoped<IPersonSkillService, PersonSkillService>();
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
            IEnumerable<Type> types = Assembly.GetAssembly(typeof(ModelAssembly))!
                .GetTypes()
                .Where(x => x.IsClass && !x.IsAbstract)
                .Where(x => x.FullName!.Contains("KaganKuscu.Model.Models") && !x.FullName!.Contains("BaseModel"))
                .Where(x => !x.FullName!.Contains("AppUser"));

            foreach (var t in types)
            {
                Type interfaceRepositoryType = typeof(IRepository<>).MakeGenericType(t);
                Type repositoryType = typeof(Repository<>).MakeGenericType(t);

                service.AddScoped(interfaceRepositoryType, repositoryType);
            }

            IEnumerable<Type> mtmTypes = Assembly.GetAssembly(typeof(ModelAssembly))!
                .GetTypes()
                .Where(x => x.IsClass && !x.IsAbstract)
                .Where(x => x.FullName!.Contains("KaganKuscu.Model.ManyToMany")).ToList();
            
            foreach (var t in mtmTypes)
            {
                Type interfaceRepositoryType = typeof(IRelationRepository<>).MakeGenericType(t);
                Type repositoryType = typeof(RelationRepository<>).MakeGenericType(t);

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
