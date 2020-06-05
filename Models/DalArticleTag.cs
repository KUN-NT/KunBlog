using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace KunBlog.DAL.Models
{
	public class DalArticleTag
	{
		//ARTICLE_ID
		[Key, Column(Order = 2)]
		[MaxLength(36)]
		public String ARTICLE_ID {get;set;}

		//TAG_ID
		[Key, Column(Order = 1)]
		[MaxLength(36)]
		public String TAG_ID {get;set;}

	}
}

