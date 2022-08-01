using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTOs.Blog;
using Entities.DTOs.Category;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        private readonly BlogContext _context;
        public BlogRepository(BlogContext context) : base(context)
        {
            _context = context;
        }

        public List<GetBlogDto> GetAllBlogs()
        {
            return _context.Blogs.OrderByDescending(x => x.Date).Include(x => x.Category).Take(5).ToList().Select(x => new GetBlogDto
            {
                Id = x.Id,
                Subject = x.Subject,
                Content = x.Content,
                Date = x.Date,
                CoverImage = x.CoverImage,
                Category = new GetCategoryDto
                {
                    Id = x.CategoryId,
                    Name = x.Category.Name
                }
            }).ToList();
        }

        public GetBlogDetailDto GetBlogDetail(int id)
        {
            return _context.Blogs.Include(x => x.Category).Where(x => x.Id == id).Select(x => new GetBlogDetailDto
            {
                Id = x.Id,
                Subject = x.Subject,
                Content = x.Content,
                Topic = x.Topic,
                Date = x.Date,
                CoverImage = x.CoverImage,
                Category = new GetCategoryDto
                {
                    Id = x.CategoryId,
                    Name = x.Category.Name
                }
            }).FirstOrDefault();
        }

        public List<GetBlogDto> GetLimited(int limit)
        {
            return _context.Blogs.OrderByDescending(x => x.Date).Include(x => x.Category).Take(limit).Select(x => new GetBlogDto
            {
                Id = x.Id,
                Subject = x.Subject,
                Content = x.Content,
                Date = x.Date,
                CoverImage = x.CoverImage,
                Category = new GetCategoryDto
                {
                    Id = x.CategoryId,
                    Name = x.Category.Name
                }
            }).ToList();
        }

        public List<GetPopularBlogDto> GetPopularBlogs()
        {
            return _context.Blogs.OrderByDescending(x => x.ViewCount).Include(x => x.Category).Select(x => new GetPopularBlogDto
            {
                Id = x.Id,
                Topic = x.Topic,
                CoverImage= x.CoverImage,
                Date = x.Date,
                Category = new GetCategoryDto
                {
                    Id = x.CategoryId,
                    Name = x.Category.Name
                }

            }).ToList();
        }
    }
}
