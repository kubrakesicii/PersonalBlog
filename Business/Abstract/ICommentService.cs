using Core.Results;
using Entities.Concrete;
using Entities.DTOs.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        DataResult<List<GetCommentDto>> GetAllComments(int blogId);
        DataResult<List<GetCommentDto>> GetAllReplies(int commentId);
        Result InsertComment(Comment comment);



    }
}
