using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var username = User.FindFirstValue(ClaimTypes.Name);

            return View(model: username);
        }
    }
}