using Microsoft.EntityFrameworkCore;

namespace KunBlog.SDM.Models
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseMySQL(@"server=localhost;uid=root;pwd=123456;
        //            port=3306;database=blog_sdm;sslmode=Preferred;");
        //    }
        //}

        public virtual DbSet<SysUser> Sys_User { get; set; } //创建实体类添加Context中

    }
}
