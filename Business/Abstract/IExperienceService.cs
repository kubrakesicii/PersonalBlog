using Core.Results;
using Entities.DTOs.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IExperienceService
    {
        DataResult<List<GetExperienceDto>> GetWorkExperiences();
        DataResult<List<GetExperienceDto>> GetSchoolExperiences();
    }
}
