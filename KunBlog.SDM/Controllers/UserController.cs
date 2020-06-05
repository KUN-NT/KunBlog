using KunBlog.SDM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KunBlog.SDM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly CoreDbContext _coreDbContext;

        public UserController(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }

        // GET api/user
        [HttpGet]
        public List<SysUser> GetUser()
        {
            return _coreDbContext.Set<SysUser>().ToList();
        }

        // GET api/user/userId
        [HttpGet("/api/user/{userId}")]
        public SysUser GetUserById(string userId)
        {
            return _coreDbContext.Set<SysUser>().FirstOrDefault(p => p.USER_ID == userId);
        }

        [HttpGet("/api/user/{userId}/{password}")]
        public SysUser GetUserById(string userId, string password)
        {
            var loginUser = _coreDbContext.Set<SysUser>().FirstOrDefault(p => p.USER_ID == userId && p.USER_PASSWORD == password);
            if (loginUser == null)
            {
                return null;
            }
            else
            {
                return loginUser;
            }
        }

        //[HttpGet]
        //public List<SysUser> Get()
        //{
        //    using (CoreDbContext _coreDbContext = new CoreDbContext())
        //    {
        //        return _coreDbContext.Set<SysUser>().ToList();
        //    }
        //}
    }
}
