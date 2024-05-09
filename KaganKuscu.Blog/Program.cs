using KaganKuscu.DataAccess;
using Microsoft.EntityFrameworkCore;
using KaganKuscu.Business.Configurations;
using KaganKuscu.Model.Models;
using KaganKuscu.Repository.Abstract;
using KaganKuscu.Repository.Concrete;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Business.Concrete;
using Microsoft.AspNetCore.Identity;

namespace KaganKuscu.Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddBusinessDI();
            builder.Services.AddRepositoryDI();
            builder.Services.AddAuthorization();

            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("connstr")));

            builder.Services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            builder.Services.ConfigureApplicationCookie(options => 
            {
                options.AccessDeniedPath = "/admin/authentication/accessdenied";
                options.LoginPath = "/admin/authentication/login";
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "adminArea",
                pattern: "{area:exists}/{controller=Authentication}/{action=Index}/{id?}"
            );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
