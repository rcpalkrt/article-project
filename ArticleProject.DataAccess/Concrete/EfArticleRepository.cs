using ArticleProject.Core.DataAccess.Concrete;
using ArticleProject.DataAccess.Abstract;
using ArticleProject.DataAccess.Contexts;
using ArticleProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.DataAccess.Concrete
{
    public class EfArticleRepository : EfRepositoryBase<Article>, IArticleRepository
    {
        private SqlDbContext _context;

        public EfArticleRepository(SqlDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
