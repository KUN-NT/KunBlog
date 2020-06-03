using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	public class SysFollow
	{
		//关注时间
		public DateTime? CREATE_DATE {get;set;}

		//关注者
		[Key]
		[MaxLength(36)]
		public String FANS_USER {get;set;}

		//被关注者
		[Key]
		[MaxLength(36)]
		public String FOLLOW_USER {get;set;}

	}
}

