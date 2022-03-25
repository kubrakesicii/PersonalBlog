using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public async Task<List<Blog>> GetAllBlogs()
        {
            return await _blogDal.GetAll();
        }

        public async Task<Blog> GetBlog(int id)
        {
            return await _blogDal.GetById(id);
        }
    }
}
