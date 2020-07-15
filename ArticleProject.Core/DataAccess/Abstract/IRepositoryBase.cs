using ArticleProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Core.DataAccess.Abstract
{
    public interface IRepositoryBase<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(int id);

        Task<T> FindAsync(Expression<Func<T, bool>> filter);

        Task<IEnumerable<T>> GetListAsync();

        Task<IEnumerable<T>> FindListAsync(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
