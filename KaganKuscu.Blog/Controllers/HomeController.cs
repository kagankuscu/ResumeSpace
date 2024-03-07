using KaganKuscu.Business.Abstract;
using KaganKuscu.Business.Concrete;
using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Models;
using KaganKuscu.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonService _personService;
        private readonly IQuoteService _quoteService;

        public HomeController(IPersonService personService, IQuoteService quoteService)
        {
            _personService = personService;
            _quoteService = quoteService;
        }

        public IActionResult Index()
        {
            HomePageVm vm = new HomePageVm
            {
                Person = _personService.GetAllPersonDto().Where(p => p.Name.Contains("Kağan Kuşcu")).FirstOrDefault(),
                Quote = _quoteService.GetRandomQuote(),
                Blogs = [],
            };
            return View(vm);
        }
    }
}
