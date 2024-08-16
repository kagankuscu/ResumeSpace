using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IResumeService _resumeService;
        private readonly IQuoteService _quoteService;

        public HomeController(IResumeService resumeService, IQuoteService quoteService)
        {
            _resumeService = resumeService;
            _quoteService = quoteService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/Home/Profile/{username}")]
        public IActionResult UserProfile()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetResume(string username)
        {
            return Json(_resumeService.GetResumeWithDetailslByUsername(username));
        }
    }
}
