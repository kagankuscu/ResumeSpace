using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KaganKuscu.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PeopleController : Controller
    {
        private readonly IPersonService _personService;

        public PeopleController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult GetAll()
        {
            return Json(new { data = _personService.GetAll() });
        }

        [HttpPost]
        public IActionResult Add(Person person)
        {
            person.Guid = Guid.NewGuid();
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
    }
}