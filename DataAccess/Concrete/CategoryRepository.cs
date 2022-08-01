using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BlogContext context) : base(context)
        {
        }

        public List<GetCategoryDto> GetAllCategories()
        {
            return _context.Categories.Select(x => new GetCategoryDto
            {
                Id = x.Id,
                Name = x.Name,
                BlogCount = _context.Blogs.Where(b => b.CategoryId == x.Id).Count()
            }).ToList();
        }
    }
}
