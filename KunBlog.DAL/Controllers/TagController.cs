using KunBlog.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KunBlog.DAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly CoreDbContext _coreDbContext;

        public TagController(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }

        // GET api/tag
        [HttpGet]
        public List<DalTag> GetTag()
        {
            return _coreDbContext.Set<DalTag>().ToList();
        }

        [HttpGet("/api/tag/{articleId}")]
        public List<DalTag> GetArticleById(string articleId)
        {
            var articleTag = _coreDbContext.Set<DalArticleTag>().Where(p => p.ARTICLE_ID == articleId).ToList();
            List<DalTag> tagList = new List<DalTag>();
            foreach (var tag in articleTag)
            {
                if (!tagList.Any(p => p.TAG_ID == tag.TAG_ID))
                {
                    tagList.Add(_coreDbContext.Set<DalTag>().FirstOrDefault(p => p.TAG_ID == tag.TAG_ID));
                }
            }
            return tagList;
        }
    }
}
