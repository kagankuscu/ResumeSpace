using ResumeSpace.Business.Abstract;
using ResumeSpace.Model;
using ResumeSpace.Model.Dtos.QuoteDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ResumeSpace.Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class QuoteController : Controller
    {
        private readonly IQuoteService _quoteService;

        public QuoteController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        public IActionResult GetAllQuote()
        {
            return Json(new { Data = _quoteService.GetAllQuote() });
        }

        public IActionResult AddQuote([FromBody] QuoteForAddDto quoteDto)
        {
            return Json(_quoteService.AddQuote(quoteDto));
        }

        [HttpPost]
        public IActionResult RemoveQuote([FromBody] Guid guid)
        {
            _quoteService.RemoveQuote(guid);

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateQuote([FromBody] QuoteForUpdateDto quoteDto)
        {
            return Json(_quoteService.UpdateQuote(quoteDto));
        }
    }
}
