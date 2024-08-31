using AutoMapper;
using ResumeSpace.Business.Abstract;
using ResumeSpace.Model.Dtos.ResumesDto;
using ResumeSpace.Model.Dtos.UserDto;
using ResumeSpace.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ResumeSpace.Blog.Areas.Admin.Controllers
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