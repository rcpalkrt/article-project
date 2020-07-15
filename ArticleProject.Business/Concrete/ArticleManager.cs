using ArticleProject.Business.Abstract;
using ArticleProject.DataAccess.Abstract;
using ArticleProject.Entities.Concrete;
using ArticleProject.Entities.DataTransferObject;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IUnitOfWorkRepository _uofw;
        private IArticleRepository _articleRepository;
        private IMapper _mapper; 

        public ArticleManager(IUnitOfWorkRepository uofw, IArticleRepository articleRepository, IMapper mapper)
        {
            _uofw = uofw;
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        #region Article Create and Update
        public async Task<bool> SaveAsync(ArticleDto model)
        {
            try
            {
                Article article = _mapper.Map<Article>(model);

                if (model.ID == 0)
                    _articleRepository.Add(article);
                else
                    _articleRepository.Update(article);

                await _uofw.CompleteAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Article Delete
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
        #endregion

        #region Search Article
        public async Task<IEnumerable<ArticleForListDto>> FindList(string searchText)
        {
            try
            {
                IEnumerable<Article> findArticleList = await _articleRepository
                    .FindListAsync(a => a.Title.Contains(searchText));

                IEnumerable<ArticleForListDto> articleList = _mapper.Map<List<ArticleForListDto>>(findArticleList);

                return articleList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Get Article by ID
        public async Task<ArticleDto> GetArticle(int id)
        {
            try
            {
                Article article = await _articleRepository.GetAsync(id);

                if (article == null)
                    throw new Exception("Cannot Find Article");

                ArticleDto articleDto = _mapper.Map<ArticleDto>(article);

                return articleDto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Get Article List
        public async Task<IEnumerable<ArticleForListDto>> GetList()
        {
            try
            {
                IEnumerable<Article> articles = await _articleRepository.GetListAsync();

                IEnumerable<ArticleForListDto> articleDtos = _mapper.Map<IEnumerable<ArticleForListDto>>(articles);

                return articleDtos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

    }
}
