using System.Security.Claims;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class PeopleController : Controller
    {
        private readonly IPersonService _personService;

        public PeopleController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult GetAll()
        {
            if(User.FindFirstValue(ClaimTypes.Role) is "Admin")
                return Json(new {Data = _personService.GetAll() });
            
            string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Guid guid = Guid.Parse(userId ?? string.Empty);

            if (guid == Guid.Empty)
                return BadRequest();

            return Json(new { Data = _personService.GetAllByAppUserGuid(guid) });
        }

        [HttpPost]
        public IActionResult Add(Person person)
        {
            person.AppUserId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;

            _personService.UpdateIsActiveForUser(Guid.Parse(person.AppUserId));
            _personService.Add(person);

            return StatusCode(201, person.Guid);
        }

        [HttpPost]
        public IActionResult Remove(Guid guid)
        {
            _personService.Remove(guid);

            return Ok();
        }

        [HttpPost]
        public IActionResult Update(Person person)
        {
            _personService.Update(person);

            return Ok();
        }
    
        [HttpPost]
        public async Task<IActionResult> UploadFiles(IFormCollection form, Person person)
        {
            string? username = User.FindFirstValue(ClaimTypes.Name);
            
            if (username is null)
                return BadRequest();

            bool result = await _personService.UploadFiles(form, username, person);
            if (result)
                return Ok();
            return BadRequest("Hataaaa :)");
        }
    }
}