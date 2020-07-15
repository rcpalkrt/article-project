using ArticleProject.Entities.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Business.Abstract
{
    public interface IArticleService
    {
        Task<bool> SaveAsync(ArticleDto model);

        Task<ArticleDto> GetArticle(int id);

        Task<IEnumerable<ArticleForListDto>> GetList();

        Task<IEnumerable<ArticleForListDto>> FindList(string searchText);

        Task<bool> Delete(int id);
    }
}
