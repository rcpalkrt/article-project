using ArticleProject.Core.DataAccess.Abstract;
using ArticleProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Core.DataAccess.Concrete
{
    public class EfRepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, IEntity, new()
    {
        private DbContext _dbContext;

        public EfRepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> filter)
        {
            var entity = await _dbContext.Set<TEntity>().SingleOrDefaultAsync(filter);

            return entity;
        }

        public async Task<IEnumerable<TEntity>> FindListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            var entities = await _dbContext.Set<TEntity>().Where(filter).ToListAsync();

            return entities;
        }

        public async Task<TEntity> GetAsync(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);

            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetListAsync()
        {
            var entities = await _dbContext.Set<TEntity>().ToListAsync();

            return entities;
        }

        public void Add(TEntity entity)
        {
            _dbContext.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }
    }
}
