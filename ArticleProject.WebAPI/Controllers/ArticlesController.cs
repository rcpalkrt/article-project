using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleProject.Business.Abstract;
using ArticleProject.Entities.DataTransferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.WebAPI.Controllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            try
            {
                IEnumerable<ArticleForListDto> articles = await _articleService.GetList();

                return Ok(articles);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("save")]
        public async Task<IActionResult> SaveArticle([FromBody]ArticleDto articleDto)
        {
            try
            {
                bool isSuccess = false;

                isSuccess = await _articleService.SaveAsync(articleDto);

                return Ok(isSuccess);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("delete/{articleId}")]
        public async Task<IActionResult> Delete(int articleId)
        {
            try
            {
                bool isSuccess = false;

                isSuccess = await _articleService.Delete(articleId);

                return Ok(isSuccess);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("getArticle/{articleId}")]
        public async Task<IActionResult> GetArticleById(int articleId)
        {
            try
            {
                ArticleDto articleDto = await _articleService.GetArticle(articleId);

                return Ok(articleDto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("search_text={searchText}")]
        public async Task<IActionResult> GetList(string searchText)
        {
            try
            {
                IEnumerable<ArticleForListDto> articles = await _articleService.FindList(searchText.ToLower());

                return Ok(articles);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}