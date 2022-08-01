using Business.Abstract;
using Core.Results;
using DataAccess.UnitOfWork;
using Entities.DTOs.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ExperienceService : IExperienceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExperienceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public DataResult<List<GetExperienceDto>> GetSchoolExperiences()
        {
            return new DataResult<List<GetExperienceDto>>(_unitOfWork.Experiences.GetSchoolExperiences(), true);
        }

        public DataResult<List<GetExperienceDto>> GetWorkExperiences()
        {
            return new DataResult<List<GetExperienceDto>>(_unitOfWork.Experiences.GetWorkExperiences(), true);
        }
    }
}
