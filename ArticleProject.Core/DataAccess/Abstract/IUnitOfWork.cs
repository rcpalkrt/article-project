using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Core.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
