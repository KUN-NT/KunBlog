using Microsoft.EntityFrameworkCore;

namespace KunBlog.SDM.Models
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysFollow>().HasKey(t => new { t.FANS_USER, t.FOLLOW_USER });
            modelBuilder.Entity<SysFollowUser>().HasKey(t => new { t.TYPE_ID, t.USER_ID });
            modelBuilder.Entity<SysPurviewRole>().HasKey(t => new { t.ROLE_ID, t.PURVIEW_ID });
            modelBuilder.Entity<SysMenuPurview>().HasKey(t => new { t.MENU_ID, t.PURVIEW_ID });
            modelBuilder.Entity<SysRoleUser>().HasKey(t => new { t.ROLE_ID, t.USER_ID });
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseMySQL(@"server=localhost;uid=root;pwd=123456;
        //            port=3306;database=blog_sdm;sslmode=Preferred;");
        //    }
        //}

        //创建实体类添加Context中
        public virtual DbSet<SysUser> SYS_USER { get; set; } 
        public virtual DbSet<SysDictionary> SYS_DICTIONARTY { get; set; } 
        public virtual DbSet<SysFollow> SYS_FOLLOW { get; set; } 
        public virtual DbSet<SysFollowType> SYS_FOLLOW_TYPE { get; set; } 
        public virtual DbSet<SysFollowUser> SYS_FOLLOW_USER { get; set; } 
        public virtual DbSet<SysGetnumber> SYS_GET_NUMBER { get; set; } 
        public virtual DbSet<SysMenu> SYS_MENU { get; set; } 
        public virtual DbSet<SysMenuPurview> SYS_MENU_PURVIEW { get; set; } 
        public virtual DbSet<SysPurview> SYS_PURVIEW { get; set; } 
        public virtual DbSet<SysPurviewRole> SYS_PURVIEW_ROLE { get; set; } 
        public virtual DbSet<SysRole> SYS_ROLE { get; set; }
        public virtual DbSet<SysRoleUser> SYS_ROLE_USER { get; set; }

    }
}
