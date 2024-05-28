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
            string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId is null)
                return NotFound();

            Guid guid = Guid.Parse(userId);
            return Json(new { Data = _skillService.GetAllByUserId(guid)});
        }

//       public IActionResult Add(SkillForAddDto skillDto) 
//       {
//            string? guid = User.FindFirstValue(ClaimTypes.NameIdentifier);
//            if (guid is null)
//                return BadRequest("User Not found");
//
//            skillDto.AppUserId = Guid.Parse(guid);
//            return Json(_skillService.Add(skillDto));
//       }
        [HttpPost]
      public IActionResult Add([FromBody] SkillForAddDto skillDto)
      {
        string? guid = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (guid is null)
          return BadRequest("User Not Found");

        skillDto.AppUserId = Guid.Parse(guid);
        return Json(_skillService.Add(skillDto));

      }

       public IActionResult ToggleStatus(Guid guid)
       {
            if(_skillService.ToggleStatus(guid))
                return Json( new { Guid = guid });
            return BadRequest();
       }

       public IActionResult Remove(Guid guid)
       {
            _skillService.Remove(guid);
            return Json(new { guid });
       }

       public IActionResult Update(SkillForUpdateDto skillDto)
       {
            return Json(_skillService.Update(skillDto));
       }
    }
}
