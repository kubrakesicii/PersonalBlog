using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTOs.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        private readonly BlogContext _context;
        public CommentRepository(BlogContext context) : base(context)
        {
            _context = context;
        }

        public List<GetCommentDto> GetAllComments(int blogId)
        {
            return _context.Comments.Where(x => x.BlogId == blogId && x.ParentId == null).Select(x => new GetCommentDto
            {
                Id = x.Id,
                UserName = x.UserName,
                Text = x.Text,
                Date = x.Date
            }).ToList();
        }

        public List<GetCommentDto> GetAllReplies(int commentId)
        {
            return _context.Comments.Where(x => x.ParentId == commentId).Select(x => new GetCommentDto
            {
                Id = x.Id,
                UserName = x.UserName,
                Text = x.Text,
                Date = x.Date
            }).ToList();
        }
    }
}
