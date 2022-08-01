using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        GetUserDto GetUserCard(int id);
    }
}
