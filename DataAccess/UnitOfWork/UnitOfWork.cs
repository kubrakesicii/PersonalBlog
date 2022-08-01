using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;
        private IUserRepository _userRepository;
        private IBlogRepository _blogRepository;
        private ICommentRepository _commentRepository;
        private IExperienceRepository _experienceRepository;
        private ISkillRepository _skillRepository;
        private ITagRepository _tagRepository;
        private ICategoryRepository _categoryRepository;


        public IUserRepository Users => _userRepository ?? new UserRepository(_context);
        public IBlogRepository Blogs => _blogRepository ?? new BlogRepository(_context);
        public ICommentRepository Comments => _commentRepository ?? new CommentRepository(_context);
        public IExperienceRepository Experiences => _experienceRepository ?? new ExperienceRepository(_context);
        public ISkillRepository Skills => _skillRepository ?? new SkillRepository(_context);
        public ITagRepository Tags => _tagRepository ?? new TagRepository(_context);
        public ICategoryRepository Categories => _categoryRepository ?? new CategoryRepository(_context);

        public UnitOfWork(BlogContext context)
        {
            if (context == null)
                throw new ArgumentNullException("dbContext can not be null.");
            _context = context;
        }


        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
