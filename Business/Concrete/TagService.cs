using Business.Abstract;
using Core.Results;
using DataAccess.UnitOfWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TagService : ITagService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TagService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public DataResult<List<Tag>> GetAllTags()
        {
            return new DataResult<List<Tag>>(_unitOfWork.Tags.GetAll(), true);
        }
    }
}
