using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AboutController : Controller
    {
        private readonly IUserService _userService;
        private readonly IExperienceService _experienceService;
        private readonly ISkillService _skillService;

        public AboutController(IUserService userService, IExperienceService experienceService, ISkillService skillService)
        {
            _userService = userService;
            _experienceService = experienceService;
            _skillService = skillService;
        }


        public IActionResult AboutMe()
        {
            var vm = new AboutViewModel();
            vm.User = _userService.GetUser(1).Data;
            vm.SchoolExperience = _experienceService.GetSchoolExperiences().Data;
            vm.WorkExperience = _experienceService.GetWorkExperiences().Data;
            vm.Skills = _skillService.GetAllSkills().Data;

            return View(vm);
        }
    }
}
