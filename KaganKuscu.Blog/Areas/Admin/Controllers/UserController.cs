using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Dtos.UserDto;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Profile()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            return Json(await _userService.GetUser(User));
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UserForUpdateDto userDto)
        {
            return Json(await _userService.UpdateUser(userDto, User));
        }
    }
}