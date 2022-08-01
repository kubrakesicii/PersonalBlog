using Business.Abstract;
using Core.Results;
using DataAccess.UnitOfWork;
using Entities.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public DataResult<List<GetCategoryDto>> GetAllCategories()
        {
            return new DataResult<List<GetCategoryDto>>(_unitOfWork.Categories.GetAllCategories(), true);
        }
    }
}
