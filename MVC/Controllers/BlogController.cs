using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;

        public BlogController(IBlogService blogService,ICommentService commentService)
        {
            _blogService = blogService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetLastBlogs()
        {
            var blogs = _blogService.GetLimited(5);
            return PartialView(blogs);
        }

        public PartialViewResult GetPopularBlogs()
        {
            var blogs = _blogService.GetPopulerBlogs();
            return PartialView(blogs);
        }


        public IActionResult BlogList()
        {
            var blogs = _blogService.GetAllBlogs().Data;
            return View(blogs);
        }

        public IActionResult Detail([FromRoute] int id)
        {
            var blog = _blogService.GetBlogDetail(id).Data;
            blog.Comments = _commentService.GetAllComments(id).Data;
            blog.Comments.ForEach(c => c.Replies = _commentService.GetAllReplies(c.Id).Data);
            return View(blog);
        }
    }
}
