using System.Security.Claims;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.ReferenceDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
  [Area("Admin")]
  [Authorize]
  public class ReferenceController : Controller
  {
    private readonly IReferenceService _referenceService;

    public ReferenceController(IReferenceService referenceService)
    {
      _referenceService = referenceService;
    }

    public IActionResult GetAllReference()
    {
      string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
      if (userId is null)
        return BadRequest("User not found");

      return Json(new { Data = _referenceService.GetAllReferenceWithResumes(Guid.Parse(userId)) });
    }

    [HttpPost]
    public IActionResult AddReference([FromBody] ReferenceForAddDto workExperienceDto)
    {
      string? appUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
      if (appUserId is null)
        return BadRequest("User not found.");

      workExperienceDto.AppUserId = Guid.Parse(appUserId);
      if (workExperienceDto is null)
        return BadRequest("Given is null");

      return Json(_referenceService.AddReference(workExperienceDto));
    }

    public IActionResult RemoveReference([FromQuery] Guid guid)
    {
      _referenceService.Remove(guid);

      return Ok();
    }

    [HttpPost]
    public IActionResult UpdateReference([FromBody] ReferenceForUpdateDto workExperienceDto)
    {
      if (workExperienceDto is null)
        return BadRequest("Given is null");

      return Json(_referenceService.UpdateReference(workExperienceDto));
    }

    [HttpPost]
    public IActionResult ToggleStatus([FromBody] Guid guid)
    {
      return Ok(_referenceService.ToggleStatus(guid));
    }

    [HttpPost]
    public async Task<IActionResult> AddImage(IFormCollection form)
    {
      bool data = await _referenceService.AddImage(form);
      if (!data)
        return BadRequest("Data is not saved.");

      return Ok();
    }
  }
}
