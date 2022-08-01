using Core.Results;
using Entities.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        DataResult<List<GetCategoryDto>> GetAllCategories();
    }
}
