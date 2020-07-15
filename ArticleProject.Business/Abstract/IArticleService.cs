using ArticleProject.Entities.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Business.Abstract
{
    public interface IArticleService
    {
        Task<bool> SaveAsync(ArticleForSaveDto model);

        Task<List<ArticleForListDto>> GetList();

        Task<List<ArticleForListDto>> FindList();

        Task<bool> Delete(int id);
    }
}
