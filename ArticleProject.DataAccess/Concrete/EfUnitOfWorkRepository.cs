using ArticleProject.Core.DataAccess.Concrete;
using ArticleProject.DataAccess.Abstract;
using ArticleProject.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.DataAccess.Concrete
{
    public class EfUnitOfWorkRepository: EfUnitOfWork, IUnitOfWorkRepository
    {

        public EfUnitOfWorkRepository(
            SqlDbContext context,
            IArticleRepository articleRepository
            ) : base(context)
        {
            ArticleRepository = articleRepository;
        }

        public IArticleRepository ArticleRepository { get; }
    }
}
