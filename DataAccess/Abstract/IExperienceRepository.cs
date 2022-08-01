using DataAccess.GenericRepository;
using Entities.Concrete;
using Entities.DTOs.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IExperienceRepository : IGenericRepository<Experience>
    {
        List<GetExperienceDto> GetWorkExperiences();
        List<GetExperienceDto> GetSchoolExperiences();

    }
}
