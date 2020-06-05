using KunBlog.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace KunBlog.DAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly CoreDbContext _coreDbContext;

        public ArticleController(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }

        // GET api/article
        [HttpGet]
        public List<DalArticle> GetArticle()
        {
            return _coreDbContext.Set<DalArticle>().ToList();
        }

        [HttpGet("/api/article/{articleId}")]
        public DalArticle GetArticleById(string articleId)
        {
            return _coreDbContext.Set<DalArticle>().FirstOrDefault(p=>p.ARTICLE_ID== articleId);
        }

        [HttpGet("/api/article/{type}/{value}")]
        public List<DalArticle> GetArticleSearch(string type, string value)
        {
            List<DalArticle> articleData = new List<DalArticle>();
            switch (type)
            {
                case "article":
                    articleData= _coreDbContext.Set<DalArticle>().Where(p => p.ARTICLE_TITLE.Contains(value)).ToList();
                    break;
                case "type":
                    var typeIds= _coreDbContext.Set<DalCatgory>().Where(p => p.TYPE_NAME.Contains(value)||p.TYPE_ID==value).Select(p=>p.TYPE_ID).ToList();
                    foreach(var typeId in typeIds)
                    {
                        var articleIds= _coreDbContext.Set<DalArticleCatgory>().Where(p => p.TYPE_ID==typeId).Select(p=>p.ARTICLE_ID).ToList();
                        foreach (var articleId in articleIds)
                        {
                            articleData.Add(_coreDbContext.Set<DalArticle>().FirstOrDefault(p => p.ARTICLE_ID == articleId));
                        }
                    }
                    break;
                case "tag":
                    var tagIds = _coreDbContext.Set<DalTag>().Where(p => p.TAG_NAME.Contains(value)||p.TAG_ID==value).Select(p => p.TAG_ID).ToList();
                    foreach (var tagId in tagIds)
                    {
                        var articleIds = _coreDbContext.Set<DalArticleTag>().Where(p => p.TAG_ID == tagId).Select(p => p.ARTICLE_ID).ToList();
                        foreach (var articleId in articleIds)
                        {
                            articleData.Add(_coreDbContext.Set<DalArticle>().FirstOrDefault(p => p.ARTICLE_ID == articleId));
                        }
                    }
                    break;
                default:
                    articleData= _coreDbContext.Set<DalArticle>().Where(p => p.ARTICLE_TITLE.Contains(value)).ToList();
                    break;
            }
            return articleData;
        }

        [HttpGet("/api/article/page/{pageIndex}/{pageSize}")]
        public List<DalArticle> GetArticlePage(string pageIndex,string pageSize)
        {
            var index = int.Parse(pageIndex);
            var size = int.Parse(pageSize);
            var temp = _coreDbContext.Set<DalArticle>()
                              .Skip(size * (index - 1))
                              .Take(size);
            return temp.AsQueryable().ToList();

        }

        [HttpGet("/api/article/count")]
        public int GetArticlePageCount()
        {
            return _coreDbContext.Set<DalArticle>().Count();
        }
    }
}
