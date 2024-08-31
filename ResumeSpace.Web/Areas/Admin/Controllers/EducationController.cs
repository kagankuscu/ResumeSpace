using System.Security.Claims;
using ResumeSpace.Business.Abstract;
using ResumeSpace.Model.Dtos.EducationDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ResumeSpace.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class EducationController : Controller
    {
      private readonly IEducationService _educationService;

        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IActionResult GetAllEducation()
        {
          if(User.FindFirstValue(ClaimTypes.Role) is "Admin")
              return Json(new {Data = _educationService.GetAllEducationWithResumes() });

          string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
          if (userId is null)
            return BadRequest("User not found");

          return Json(new { Data = _educationService.GetAllEducationWithResumes(Guid.Parse(userId)) });
        }
        
        [HttpPost]
        public IActionResult AddEducation([FromBody] EducationForAddDto educationDto)
        {
          string? appUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
          if (appUserId is null)
            return BadRequest("User not found.");

          educationDto.AppUserId = Guid.Parse(appUserId);
          if (educationDto is null)
            return BadRequest("Given is null");

          return Json(_educationService.AddEducation(educationDto));
        }

        public IActionResult RemoveEducation([FromQuery] Guid guid)
        {
          _educationService.RemoveEducation(guid);

          return Ok();
        }
        
        [HttpPost]
        public IActionResult UpdateEducation([FromBody] EducationForUpdateDto educationDto)
        {
          if (educationDto is null)
            return BadRequest("Given is null");
          
          return Json(_educationService.UpdateEducation(educationDto));
        }

        [HttpPost]
        public IActionResult ToggleStatus([FromBody] Guid guid)
        {
          return Ok(_educationService.ToggleStatus(guid));
        }
    }
}
