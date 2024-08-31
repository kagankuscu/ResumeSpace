using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ResumeSpace.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class DashboardController : Controller
    {

        public IActionResult Index()
        {
            return RedirectToAction("Resumes");
        }

        public IActionResult Resumes()
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

        [Authorize(Roles = "Admin")]
        public IActionResult Quotes()
        {
            return View();
        }
    }
}
