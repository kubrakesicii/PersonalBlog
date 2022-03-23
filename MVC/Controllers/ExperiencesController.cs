using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class ExperiencesController : Controller
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceRepository());


        // PartialView dönsün -> Resume sayfasının exp kısmı
        public async Task<PartialViewResult> GetExperiences()
        {
            var experience = await _experienceManager.GetAllExperiences();
            return PartialView(experience);
        }
    }
}
