using KaganKuscu.Business.Abstract;
using KaganKuscu.Business.Concrete;
using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Models;
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
            PersonDto person = _personService.GetAllPersonDto().Where(p => p.Name.Contains("Kağan Kuşcu")).FirstOrDefault();
            return View(person);
        }
    }
}
