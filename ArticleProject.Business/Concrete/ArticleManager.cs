using ArticleProject.Business.Abstract;
using ArticleProject.DataAccess.Abstract;
using ArticleProject.Entities.Concrete;
using ArticleProject.Entities.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IUnitOfWorkRepository _uofw;
        private IArticleRepository _articleRepository;

        public ArticleManager(IUnitOfWorkRepository uofw, IArticleRepository articleRepository)
        {
            _uofw = uofw;
            _articleRepository = articleRepository;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                Article article = await _articleRepository.GetAsync(id);

                if (article == null)
                    throw new Exception("Cannot Find Article");

                _articleRepository.Delete(article);
                await _uofw.CompleteAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<List<ArticleForListDto>> FindList(string searchText)
        {
            throw new NotImplementedException();
        }

        public Task<ArticleForSaveDto> GetArticle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticleForListDto>> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync(ArticleForSaveDto model)
        {
            throw new NotImplementedException();
        }
    }
}
