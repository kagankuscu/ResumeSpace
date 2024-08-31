using ResumeSpace.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ResumeSpace.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SocialMediaIconController : Controller
    {
        private readonly ISocialMediaIconService _socialMediaIconService;

        public SocialMediaIconController(ISocialMediaIconService socialMediaIconService)
        {
            _socialMediaIconService = socialMediaIconService;
        }

        public IActionResult GetAllSocialMediaIcon() => Json(new { Data = _socialMediaIconService.GetAllSocialMediaIcon() });
    }
}
