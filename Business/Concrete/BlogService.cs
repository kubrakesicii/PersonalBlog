using Business.Abstract;
using Core.Results;
using DataAccess.UnitOfWork;
using Entities.Concrete;
using Entities.DTOs.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogService : IBlogService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BlogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public DataResult<List<GetBlogDto>> GetAllBlogs()
        {
            return new DataResult<List<GetBlogDto>>(_unitOfWork.Blogs.GetAllBlogs(), true);
        }

        public DataResult<GetBlogDetailDto> GetBlogDetail(int id)
        {
            return new DataResult<GetBlogDetailDto>(_unitOfWork.Blogs.GetBlogDetail(id), true);
        }

        public DataResult<List<GetBlogDto>> GetLimited(int limit)
        {
            return new DataResult<List<GetBlogDto>>(_unitOfWork.Blogs.GetLimited(limit), true);
        }

        public DataResult<List<GetPopularBlogDto>> GetPopulerBlogs()
        {
            return new DataResult<List<GetPopularBlogDto>>(_unitOfWork.Blogs.GetPopularBlogs(), true);
        }
    }
}
