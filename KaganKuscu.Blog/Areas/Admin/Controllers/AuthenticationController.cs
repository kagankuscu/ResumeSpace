using KaganKuscu.Business.Abstract;
using KaganKuscu.EmailService.Concrete;
using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Dtos.UserDto;
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
        public IActionResult Recover()
        {
            return View();
        }
        public IActionResult ResetPassword()
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
        public async Task<IActionResult> Register([FromBody] UserForRegistration userDto)
        {
            return Json(await _authService.Register(userDto));
        }

        [HttpPost]
        public async Task<IActionResult> Recover([FromBody] UserForForgotPasswordDto forgotPassword)
        {
            return Json(await _authService.Recover(forgotPassword));
        }
        [HttpPost]
        public async Task<IActionResult> Reset([FromBody] UserForResetPasswordDto userDto)
        {
            return Json(await _authService.Reset(userDto));
        }
        public async Task<IActionResult> Logout()
        {
            if (!await _authService.Logout())
                return BadRequest();
            return RedirectToAction(nameof(Login));
        }
    }
}