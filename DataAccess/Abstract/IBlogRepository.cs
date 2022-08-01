using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTOs.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        List<GetBlogDto> GetLimited(int limit);
        List<GetPopularBlogDto> GetPopularBlogs();

        List<GetBlogDto> GetAllBlogs();

        GetBlogDetailDto GetBlogDetail(int id);

    }
}
