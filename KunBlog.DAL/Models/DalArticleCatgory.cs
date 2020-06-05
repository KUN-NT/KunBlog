using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace KunBlog.DAL.Models
{
	public class DalArticleCatgory
	{
		//ARTICLE_ID
		[Key, Column(Order = 2)]
		[MaxLength(36)]
		public String ARTICLE_ID {get;set;}

		//TYPE_ID
		[Key, Column(Order = 1)]
		[MaxLength(36)]
		public String TYPE_ID {get;set;}

	}
}

