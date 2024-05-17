using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UtilityController : Controller
    {
        public IActionResult Upcoming()
        {
            return View();
        }
    }
}