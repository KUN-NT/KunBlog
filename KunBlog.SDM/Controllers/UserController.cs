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
        public List<SysUser> GetUserById(string userId)
        {
            return _coreDbContext.Set<SysUser>().Where(p=>p.USER_ID==userId).ToList();
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
