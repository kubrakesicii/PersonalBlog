using Business.Abstract;
using Core.Results;
using DataAccess.UnitOfWork;
using Entities.Concrete;
using Entities.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        DataResult<GetUserDto> IUserService.GetUser(int id)
        {
            return new DataResult<GetUserDto>(_unitOfWork.Users.GetUserCard(id),true);
        }
    }
}
