using System.Security.Claims;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.WorkExperienceDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class WorkExperienceController : Controller
    {
      private readonly IWorkExperienceService _workExperienceService;

      public WorkExperienceController(IWorkExperienceService workExperienceService)
      {
        _workExperienceService = workExperienceService;
      }

      public IActionResult GetAllWorkExperience()
      {
        string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId is null)
          return BadRequest("User not found");

        return Json(new { Data = _workExperienceService.GetAllWorkExperienceWithResumes(Guid.Parse(userId)) });
      }

      [HttpPost]
      public IActionResult AddWorkExperience([FromBody] WorkExperienceForAddDto workExperienceDto)
      {
        string? appUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (appUserId is null)
          return BadRequest("User not found.");

        workExperienceDto.AppUserId = Guid.Parse(appUserId);
        if (workExperienceDto is null)
          return BadRequest("Given is null");

        return Json(_workExperienceService.AddWorkExperience(workExperienceDto));
      }

      public IActionResult RemoveWorkExperience([FromQuery] Guid guid)
      {
        _workExperienceService.Remove(guid);

        return Ok();
      }

      [HttpPost]
      public IActionResult UpdateWorkExperience([FromBody] WorkExperienceForUpdateDto workExperienceDto)
      {
        if (workExperienceDto is null)
          return BadRequest("Given is null");

        return Json(_workExperienceService.UpdateWorkExperience(workExperienceDto));
      }

      [HttpPost]
      public IActionResult ToggleStatus([FromBody] Guid guid)
      {
        return Ok(_workExperienceService.ToggleStatus(guid));
      }

    }
}
