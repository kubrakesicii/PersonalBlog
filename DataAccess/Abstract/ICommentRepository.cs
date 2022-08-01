using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTOs.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        List<GetCommentDto> GetAllComments(int blogId);
    }
}
