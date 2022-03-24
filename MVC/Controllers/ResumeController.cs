using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class ResumeController : Controller
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceRepository());
        SkillManager _skillManager = new SkillManager(new EfSkillRepository());

        public async Task<IActionResult> Get()
        {
            var experiences = await _experienceManager.GetAllExperiences();
            var skills = await _skillManager.GetAllSkills();

            ResumeViewModel resumeViewModel = new ResumeViewModel();
            resumeViewModel.Experiences = experiences;
            resumeViewModel.Skills = skills;

            return View(resumeViewModel);
        }
    }
}
