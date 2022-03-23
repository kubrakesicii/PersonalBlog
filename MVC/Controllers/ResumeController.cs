using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class ResumeController : Controller
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceRepository());

        public async Task<IActionResult> Get()
        {
            var experiences = await _experienceManager.GetAllExperiences();
            return View(experiences);
        }
    }
}
