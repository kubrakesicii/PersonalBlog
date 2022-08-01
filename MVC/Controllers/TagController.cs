using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetAllTags()
        {
            var tags = _tagService.GetAllTags();
            return PartialView(tags);
        }
    }
}
