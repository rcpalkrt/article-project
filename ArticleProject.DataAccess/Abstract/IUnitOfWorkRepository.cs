using ArticleProject.Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.DataAccess.Abstract
{
    public interface IUnitOfWorkRepository : IUnitOfWork
    {
        IArticleRepository ArticleRepository { get; }
    }
}
