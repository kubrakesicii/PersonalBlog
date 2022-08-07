using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IBlogService _blogService;

        public CommentController(ICommentService commentService, IBlogService blogService)
        {
            _commentService = commentService;
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LeaveComment(int blogId,string username, string comment)
        {
            Console.WriteLine("Blog  ID: ", blogId);
            Console.WriteLine("username: ", username);
            Console.WriteLine("comment: ", comment);

            var newC = new Comment
            {
                BlogId = blogId,
                UserName = username,
                Text = comment,
                Date = DateTime.Now,
                ParentId = null,
                IsActive = 1
            };

            _commentService.InsertComment(newC);

            //var blog = _blogService.GetBlogDetail(blogId);

            return RedirectToAction("Detail", "Blog", new { id = blogId });

        }
    }
}
