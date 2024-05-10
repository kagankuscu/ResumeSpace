using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthenticationController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AuthenticationController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserForAuthentication userDto)
        {
            var result = await _signInManager.PasswordSignInAsync(userDto.Username!, userDto.Password!, userDto.RememberMe, false);

            if (result.Succeeded)
                return RedirectToAction(nameof(Index), nameof(DashboardController).Replace("Controller", ""));

            return BadRequest(result.IsNotAllowed);
        }

        public IActionResult Register() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserForRegistration userDto)
        {
            AppUser user = new AppUser 
                {
                    Email = userDto.Email,
                    UserName = userDto.Username,
                };
            var result = await _userManager.CreateAsync(user, userDto.Password!);

            if (result.Succeeded)
                await _userManager.AddToRoleAsync(user, "User");

            return RedirectToAction(nameof(Login));
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}