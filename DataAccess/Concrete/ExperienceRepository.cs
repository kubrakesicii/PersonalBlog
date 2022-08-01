using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTOs.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ExperienceRepository : GenericRepository<Experience>, IExperienceRepository
    {
        public ExperienceRepository(BlogContext context) : base(context)
        {
        }

        public List<GetExperienceDto> GetSchoolExperiences()
        {
            return _context.Experiences.Where(x => x.Type == 1).Select(x => new GetExperienceDto
            {
                Id = x.Id,
                Name = x.CompanyName,
                Description = x.Description,
                Title = x.Title,
                TimeInterval = x.TimeInterval
            }).ToList();
        }

        public List<GetExperienceDto> GetWorkExperiences()
        {
            return _context.Experiences.Where(x => x.Type == 2).Select(x => new GetExperienceDto
            {
                Id = x.Id,
                Name = x.CompanyName,
                Description = x.Description,
                Title = x.Title,
                TimeInterval = x.TimeInterval
            }).ToList();
        }
    }
}
