using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        Task Insert(TEntity entity);
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
    }
}
