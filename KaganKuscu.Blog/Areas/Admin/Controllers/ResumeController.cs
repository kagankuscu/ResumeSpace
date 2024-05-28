using System.Security.Claims;
using KaganKuscu.Business.Abstract;
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
            if(User.FindFirstValue(ClaimTypes.Role) is "Admin")
                return Json(new {Data = _resumeService.GetAll() });
            
            string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Guid guid = Guid.Parse(userId ?? string.Empty);

            if (guid == Guid.Empty)
                return BadRequest();

            return Json(new { Data = _resumeService.GetAllByAppUserGuid(guid) });
        }

        [HttpPost]
        public IActionResult Add(Resume resume)
        {
            resume.AppUserId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;

            _resumeService.UpdateIsActiveForUser(Guid.Parse(resume.AppUserId));
            _resumeService.Add(resume);

            return StatusCode(201, resume.Guid);
        }

        [HttpPost]
        public IActionResult Remove(Guid guid)
        {
            _resumeService.Remove(guid);

            return Ok();
        }

        [HttpPost]
        public IActionResult Update(Resume resume)
        {
            _resumeService.Update(resume);

            return Ok();
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
            Resume? resume = _resumeService.GetById(guid);
            if (resume is null)
                return BadRequest();
            
            resume.IsActive = !resume.IsActive;
            if (_resumeService.UpdateIsActiveForUser(Guid.Parse(resume.AppUserId)))
                _resumeService.Update(resume);
            return Ok();
        }
    }
}