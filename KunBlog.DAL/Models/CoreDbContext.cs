using Microsoft.EntityFrameworkCore;

namespace KunBlog.DAL.Models
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DalArticleCatgory>().HasKey(t => new { t.ARTICLE_ID, t.TYPE_ID });
            modelBuilder.Entity<DalArticleTag>().HasKey(t => new { t.ARTICLE_ID, t.TAG_ID });
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
        public virtual DbSet<DalArticle> DAL_ARTICLE { get; set; } 
        public virtual DbSet<DalArticleCatgory> DAL_ARTICLE_CATGORY { get; set; } 
        public virtual DbSet<DalArticleTag> DAL_ARTICLE_TAG { get; set; } 
        public virtual DbSet<DalCatgory> DAL_CATGORY { get; set; } 
        public virtual DbSet<DalComment> DAL_COMMENT { get; set; } 
        public virtual DbSet<DalTag> DAL_TAG { get; set; } 
    }
}
