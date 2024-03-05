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

        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult Index()
        {
            HomePageVm vm = new HomePageVm
            {
                Person = _personService.GetAllPersonDto().Where(p => p.Name.Contains("Kağan Kuşcu")).FirstOrDefault(),
                Quote = new Quote
                {
                    Content = @"My commute is extremely short. Just 20 steps across the apartment to my office
                    overlooking Butler St. Sometimes when I'm feeling fancy, I'll walk 2 blocks down the
                    street for coffee first. Either way, it's very convenient.",
                    Owner = "John Doe",
                },
                Blogs = [],
            };
            return View(vm);
        }
    }
}
