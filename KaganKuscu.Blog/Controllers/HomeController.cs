using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.EmailDto;
using KaganKuscu.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IResumeService _resumeService;
        private readonly IQuoteService _quoteService;
        private readonly IEmailService _emailService;

        public HomeController(IResumeService resumeService, IQuoteService quoteService, IEmailService emailService)
        {
            _resumeService = resumeService;
            _quoteService = quoteService;
            _emailService = emailService;
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
        [HttpGet]
        public IActionResult GetRandomQuote()
        {
            return Json(_quoteService.GetRandomQuote());
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Json(_resumeService.GetAllUsers());
        }
        [HttpPost]
        public async Task<IActionResult> SendMail([FromBody] EmailForSendDto emailSend)
        {
            return Ok(await _emailService.SenMail(emailSend));
        }
    }
}
