using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authService;

        public AuthenticationController(IAuthenticationService authService)
        {
            _authService = authService;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpPost]
        public async Task<bool> Login([FromBody] UserForAuthentication userDto)
        {
            return await _authService.Login(userDto);
        }

        [HttpPost]
        public async Task<bool> Register(UserForRegistration userDto)
        {
            return await _authService.Register(userDto);
        }

        public async Task<IActionResult> Logout()
        {
            if (!await _authService.Logout())
                return BadRequest();
            return RedirectToAction(nameof(Login));
        }
    }
}