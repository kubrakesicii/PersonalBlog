using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        public async Task Delete(TEntity entity)
        {
            using var c = new BlogContext();
            c.Remove(entity);
            await c.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            using var c = new BlogContext();
            return await c.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            using var c = new BlogContext();
            return await c.Set<TEntity>().FindAsync(id);
        }

        public async Task Insert(TEntity entity)
        {
            using var c = new BlogContext();
            await c.AddAsync(entity);
            await c.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            using var c = new BlogContext();
            c.Update(entity);
            await c.SaveChangesAsync();
        }
    }
}
