using Core.Results;
using Entities.Concrete;
using Entities.DTOs.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        DataResult<List<GetBlogDto>> GetLimited(int limit);
        DataResult<List<GetPopularBlogDto>> GetPopulerBlogs();
        DataResult<List<GetBlogDto>> GetAllBlogs();
        DataResult<GetBlogDetailDto> GetBlogDetail(int id);

    }
}
