using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IBlogService _blogService;
        private readonly ITagService _tagService;
        private readonly ICategoryService _categoryService;

        public HomeController(IUserService userService, IBlogService blogService, ITagService tagService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _userService = userService;
            _tagService = tagService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Homepage()
        {
            HomepageViewModel vm = new HomepageViewModel();
            vm.LastBlogs = _blogService.GetLimited(5).Data;
            vm.PopularBlogs = _blogService.GetPopulerBlogs().Data;
            vm.User = _userService.GetUser(1).Data;
            vm.Tags = _tagService.GetAllTags().Data;
            vm.Categories = _categoryService.GetAllCategories().Data;

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}