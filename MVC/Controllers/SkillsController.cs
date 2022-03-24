using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class SkillsController : Controller
    {
        SkillManager _skillManager = new SkillManager(new EfSkillRepository());

        // PartialView dönsün -> Resume sayfasının Coding Skills kısmı
        public async Task<PartialViewResult> GetSkills()
        {
            return PartialView(await _skillManager.GetAllSkills());
        }
    }
}
