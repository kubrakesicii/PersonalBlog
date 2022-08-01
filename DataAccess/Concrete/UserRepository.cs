using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly BlogContext _context;
        public UserRepository(BlogContext context) : base(context)
        {
            _context = context;
        }

        public GetUserDto GetUserCard(int id)
        {
            return _context.Users.Where(x => x.Id == id).Select(x => new GetUserDto
            {
                Id = x.Id,
                Name = x.Name,
                Overview = x.Overview,
                Title = x.Title
            }).FirstOrDefault();
        }
    }
}
