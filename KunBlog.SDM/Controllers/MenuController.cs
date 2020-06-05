using KunBlog.SDM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KunBlog.SDM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly CoreDbContext _coreDbContext;

        public MenuController(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }

        // GET api/menu/userId
        [HttpGet("/api/menu/{userId}")]
        public List<SysMenu> GetUserById(string userId)
        {
            var roleUser = _coreDbContext.Set<SysRoleUser>().Where(p => p.USER_ID == userId).ToList();
            List<SysPurviewRole> purviewList = new List<SysPurviewRole>();
            foreach (var role in roleUser)
            {
                foreach (var purview in _coreDbContext.Set<SysPurviewRole>().Where(p => p.ROLE_ID == role.ROLE_ID).ToList())
                {
                    if (!purviewList.Any(p=>p.PURVIEW_ID == purview.PURVIEW_ID))
                    { 
                        purviewList.Add(purview); 
                    }
                }
            }
            List<SysMenuPurview> menuList = new List<SysMenuPurview>();
            foreach(var purview in purviewList)
            {
                foreach (var menu in _coreDbContext.Set<SysMenuPurview>().Where(p => p.PURVIEW_ID == purview.PURVIEW_ID).ToList())
                {
                    if (!menuList.Any(p => p.MENU_ID == menu.MENU_ID))
                    {
                        menuList.Add(menu);
                    }
                }
            }
            List<SysMenu> menuResult = new List<SysMenu>();
            foreach(var menu in menuList)
            {
                menuResult.Add(_coreDbContext.Set<SysMenu>().FirstOrDefault(p => p.MENU_ID == menu.MENU_ID));
            }
            return menuResult.OrderBy(p=>p.MENU_SEQ).ToList();
        }
    }
}
