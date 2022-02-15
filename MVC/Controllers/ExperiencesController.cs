using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ExperiencesController : Controller
    {

        // PartialView dönsün -> Resume sayfasının exp kısmı
        public IActionResult Index()
        {
            return View();
        }
    }
}
