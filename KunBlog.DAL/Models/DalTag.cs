using System;
using System.ComponentModel.DataAnnotations;

namespace KunBlog.DAL.Models
{
    public class DalTag
	{
		//ARTICLE_NUM
		[MaxLength()]
		public String ARTICLE_NUM {get;set;}

		//CREATE_DATE
		public DateTime? CREATE_DATE {get;set;}

		//TAG_ID
		[Key]
		[MaxLength(36)]
		public String TAG_ID {get;set;}

		//TAG_NAME
		[MaxLength(36)]
		public String TAG_NAME {get;set;}

		//USER_ID
		[MaxLength(36)]
		public String USER_ID {get;set;}

		//œ‘ æ—˘ Ω
		[MaxLength(20)]
		public String TAG_STYLE { get; set; }

	}
}

