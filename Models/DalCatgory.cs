using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.DAL.Models
{
	public class DalCatgory
	{
		//文章数量
		[MaxLength()]
		public String ARTICLE_NUM {get;set;}

		//CREATE_DATE
		public DateTime? CREATE_DATE {get;set;}

		//TYPE_ID
		[Key]
		[MaxLength(36)]
		public String TYPE_ID {get;set;}

		//TYPE_NAME
		[MaxLength(50)]
		public String TYPE_NAME {get;set;}

		//USER_ID
		[MaxLength(36)]
		public String USER_ID {get;set;}

	}
}

