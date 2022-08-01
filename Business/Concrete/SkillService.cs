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
    public class SkillService : ISkillService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SkillService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public DataResult<List<Skill>> GetAllSkills()
        {
            return new DataResult<List<Skill>>(_unitOfWork.Skills.GetAll(), true);
        }
    }
}
