using KunBlog.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KunBlog.DAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly CoreDbContext _coreDbContext;

        public TypeController(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }

        // GET api/type
        [HttpGet]
        public List<DalCatgory> GetTag()
        {
            return _coreDbContext.Set<DalCatgory>().ToList();
        }

        [HttpGet("/api/type/{articleId}")]
        public List<DalCatgory> GetArticleById(string articleId)
        {
            var articleType = _coreDbContext.Set<DalArticleCatgory>().Where(p => p.ARTICLE_ID == articleId).ToList();
            List<DalCatgory> typeList = new List<DalCatgory>();
            foreach (var type in articleType)
            {
                if (!typeList.Any(p => p.TYPE_ID == type.TYPE_ID))
                {
                    typeList.Add(_coreDbContext.Set<DalCatgory>().FirstOrDefault(p => p.TYPE_ID == type.TYPE_ID));
                }
            }
            return typeList;
        }
    }
}
