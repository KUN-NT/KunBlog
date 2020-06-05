using System;
using System.ComponentModel.DataAnnotations;

namespace KunBlog.DAL.Models
{
    public class DalArticle
	{
		//文章内容
		[MaxLength(65535)]
		public String ARTICLE_CONTENT {get;set;}

		//文章编号
		[Key]
		[MaxLength(36)]
		public String ARTICLE_ID {get;set;}

		//文章图片
		[MaxLength(100)]
		public String ARTICLE_IMG {get;set;}

		//文章标题
		[MaxLength(100)]
		public String ARTICLE_TITLE {get;set;}

		//CREATE_BY
		[MaxLength(36)]
		public String CREATE_BY {get;set;}

		//CREATE_DATE
		public DateTime? CREATE_DATE {get;set;}

		//踩数
		[MaxLength()]
		public String DOWN_NUM {get;set;}

		//是否发布
		[MaxLength(1)]
		public String IS_RELASE {get;set;}

		//是否显示在首页
		[MaxLength(1)]
		public String IS_SHOW {get;set;}

		//是否置顶
		[MaxLength(1)]
		public String IS_TOP {get;set;}

		//阅读数量
		[MaxLength()]
		public String READ_NUM {get;set;}

		//点赞数
		[MaxLength()]
		public String UP_NUM {get;set;}

		//UPDATE_BY
		[MaxLength(36)]
		public String UPDATE_BY {get;set;}

		//UPDATE_DATE
		public DateTime? UPDATE_DATE {get;set;}

		//文章作者
		[MaxLength(36)]
		public String USER_ID {get;set;}

	}
}

