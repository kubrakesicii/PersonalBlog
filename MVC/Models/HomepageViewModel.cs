using Entities.Concrete;
using Entities.DTOs.Blog;
using Entities.DTOs.Category;
using Entities.DTOs.User;

namespace MVC.Models
{
    public class HomepageViewModel
    {
        public List<GetBlogDto> LastBlogs { get; set; }
        public List<GetPopularBlogDto> PopularBlogs { get; set; }
        public List<GetCategoryDto> Categories { get; set; }
        public List<Tag> Tags { get; set; }
        public GetUserDto User { get; set; }
    }
}
