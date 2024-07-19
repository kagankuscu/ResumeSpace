using System.Security.Claims;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ResumeController : Controller
    {
        private readonly IResumeService _resumeService;

        public ResumeController(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        public IActionResult GetAll()
        {
            // if(User.FindFirstValue(ClaimTypes.Role) is "Admin")
            //     return Json(new {Data = _resumeService.GetAllByAppUserGuid() });

            string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Guid guid = Guid.Parse(userId ?? string.Empty);

            if (guid == Guid.Empty)
                return BadRequest();

            return Json(new { Data = _resumeService.GetAllByAppUserGuid(guid) });
        }

        [HttpPost]
        public IActionResult Add([FromBody] ResumeForAddDto resumeDto)
        {
            resumeDto.AppUserId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
            _resumeService.UpdateStatusForUserGuid(Guid.Parse(resumeDto.AppUserId));
            return StatusCode(201, _resumeService.AddResume(resumeDto));
        }

        [HttpPost]
        public IActionResult Remove(Guid guid)
        {
            _resumeService.RemoveResume(guid);

            return Ok();
        }

        [HttpPost]
        public IActionResult Update([FromBody] ResumeForUpdateDto resumeDto)
        {
            return Ok(_resumeService.UpdateResume(resumeDto));
        }

        [HttpPost]
        public async Task<IActionResult> UploadFiles(IFormCollection form, Resume resume)
        {
            string? username = User.FindFirstValue(ClaimTypes.Name);

            if (username is null)
                return BadRequest();

            bool result = await _resumeService.UploadFiles(form, username, resume);
            if (result)
                return Ok();
            return BadRequest("Hataaaa :)");
        }

        [HttpPost]
        public IActionResult ToggleStatus(Guid guid)
        {
            return Ok(_resumeService.ToggleStatus(guid));
        }
    }
}