using System.Security.Claims;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.SkillsDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize()]
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IActionResult GetAll()
        {
            if(User.FindFirstValue(ClaimTypes.Role) is "Admin")
                return Json(new {Data = _skillService.GetAllSkillWithResumes() });

            string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId is null)
                return NotFound();

            Guid guid = Guid.Parse(userId);
            return Json(new { Data = _skillService.GetAllSkillWithResumes(guid)});
        }

        [HttpPost]
        public IActionResult Add([FromBody] SkillForAddDto skillDto)
        {
          string? guid = User.FindFirstValue(ClaimTypes.NameIdentifier);
          if (guid is null)
            return BadRequest("User Not Found");

          skillDto.AppUserId = Guid.Parse(guid);
          return Json(_skillService.AddSkill(skillDto));
        }

       public IActionResult ToggleStatus(Guid guid)
       {
            if(_skillService.ToggleStatus(guid))
                return Json( new { Guid = guid });
            return BadRequest();
       }

       [HttpPost]
       public IActionResult Remove([FromBody] Guid guid)
       {
            _skillService.RemoveSkill(guid);
            return Json(new { guid });
       }

       [HttpPost]
       public IActionResult Update([FromBody] SkillForUpdateDto skillDto)
       {
            return Json(_skillService.UpdateSkill(skillDto));
       }
    }
}
