using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var blogs = await _blogManager.GetAllBlogs();
            return View(blogs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var blog = await _blogManager.GetBlog(id);
            return View(blog);
        }
    }
}
