using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult People()
        {
            return View();
        }

        public IActionResult Files()
        {
            return View();
        }

        public IActionResult Educations()
        {
            return View();
        }

        public IActionResult Skills()
        {
            return View();
        }

        public IActionResult WorkExperiences()
        {
            return View();
        }

        public IActionResult References()
        {
            return View();
        }

        public IActionResult SocialMedias()
        {
            return View();
        }

        public IActionResult Quotes()
        {
            return View();
        }
    }
}