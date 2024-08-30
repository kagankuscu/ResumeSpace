using System.Security.Claims;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.SocialMediaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IActionResult GetAllSocialMedia()
        {
            if(User.FindFirstValue(ClaimTypes.Role) is "Admin")
                return Json(new {Data = _socialMediaService.GetAllSocialMediaWithResumes() });

            string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId is null)
                return BadRequest("User not found");

            return Json(new { Data = _socialMediaService.GetAllSocialMediaWithResumes(Guid.Parse(userId)) });
        }

        [HttpPost]
        public IActionResult AddSocialMedia([FromBody] SocialMediaForAddDto socialMediaDto)
        {
            string? appUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (appUserId is null)
                return BadRequest("User not found.");

            socialMediaDto.AppUserId = Guid.Parse(appUserId);
            if (socialMediaDto is null)
                return BadRequest("Given is null");

            return Json(_socialMediaService.AddSocialMedia(socialMediaDto));
        }

        public IActionResult RemoveSocialMedia([FromQuery] Guid guid)
        {
            _socialMediaService.RemoveSocialMedia(guid);

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia([FromBody] SocialMediaForUpdateDto socialMediaDto)
        {
            if (socialMediaDto is null)
                return BadRequest("Given is null");

            return Json(_socialMediaService.UpdateSocialMedia(socialMediaDto));
        }

        [HttpPost]
        public IActionResult ToggleStatus([FromBody] Guid guid)
        {
            return Ok(_socialMediaService.ToggleStatus(guid));
        }
    }
}