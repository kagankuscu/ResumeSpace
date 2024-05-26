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
            HomePageVm vm = new HomePageVm
            {
                Resume = _resumeService.GetAllResumeDto().Where(p => p.Name.Contains("Kağan Kuşcu")).FirstOrDefault()!,
                Quote = _quoteService.GetRandomQuote(),
                Blogs = [],
            };
            return View(vm);
        }
    }
}
