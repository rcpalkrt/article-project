using ArticleProject.Core.DataAccess.Abstract;
using ArticleProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.DataAccess.Abstract
{
    public interface IArticleRepository : IRepositoryBase<Article>
    {
    }
}
