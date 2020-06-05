using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.DAL.Models
{
	public class DalComment
	{
		//文章编号
		[MaxLength(36)]
		public String ARTICLE_ID {get;set;}

		//评论内容
		[MaxLength(65535)]
		public String COMMENT_CONTENT {get;set;}

		//评论编号
		[Key]
		[MaxLength(36)]
		public String COMMENT_ID {get;set;}

		//CREATE_DATE
		public DateTime? CREATE_DATE {get;set;}

		//是否删除
		[MaxLength(1)]
		public String IS_DEL {get;set;}

		//用户编号
		[MaxLength(36)]
		public String USER_ID {get;set;}

	}
}

