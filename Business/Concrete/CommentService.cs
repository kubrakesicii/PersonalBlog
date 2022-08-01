using Business.Abstract;
using Core.Results;
using DataAccess.UnitOfWork;
using Entities.DTOs.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public DataResult<List<GetCommentDto>> GetAllComments(int blogId)
        {
            return new DataResult<List<GetCommentDto>>(_unitOfWork.Comments.GetAllComments(blogId), true);
        }
    }
}
