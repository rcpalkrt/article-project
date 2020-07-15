using ArticleProject.Core.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Core.DataAccess.Concrete
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private DbContext _dbContext;

        public EfUnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CompleteAsync()
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    await _dbContext.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message);
                }

                finally
                {
                    transaction.Dispose();
                }
            }

        }
    }
}
