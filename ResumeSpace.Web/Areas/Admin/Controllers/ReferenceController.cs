using System.Security.Claims;
using ResumeSpace.Business.Abstract;
using ResumeSpace.Model.Dtos.ReferenceDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ResumeSpace.Blog.Areas.Admin.Controllers
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
      if(User.FindFirstValue(ClaimTypes.Role) is "Admin")
        return Json(new {Data = _referenceService.GetAllReferenceWithResumes() });

      string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
      if (userId is null)
        return BadRequest("User not found");

      return Json(new { Data = _referenceService.GetAllReferenceWithResumes(Guid.Parse(userId)) });
    }

    [HttpPost]
    public IActionResult AddReference([FromBody] ReferenceForAddDto referenceDto)
    {
      string? appUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
      if (appUserId is null)
        return BadRequest("User not found.");

      referenceDto.AppUserId = Guid.Parse(appUserId);
      if (referenceDto is null)
        return BadRequest("Given is null");

      return Json(_referenceService.AddReference(referenceDto));
    }

    public IActionResult RemoveReference([FromQuery] Guid guid)
    {
      _referenceService.RemoveReference(guid);

      return Ok();
    }

    [HttpPost]
    public IActionResult UpdateReference([FromBody] ReferenceForUpdateDto referenceDto)
    {
      if (referenceDto is null)
        return BadRequest("Given is null");

      return Json(_referenceService.UpdateReference(referenceDto));
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
