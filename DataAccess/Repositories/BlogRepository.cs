using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BlogRepository : IGenericDal<Blog>
    {
        public Task Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blog>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Blog> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Blog entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
