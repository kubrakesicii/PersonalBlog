using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IBlogRepository Blogs { get; }
        ICommentRepository Comments { get; }
        IExperienceRepository Experiences { get;}
        ISkillRepository Skills { get; }
        ITagRepository Tags { get; }
        ICategoryRepository Categories { get; }
        int SaveChanges();

    }
}
