using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	public class SysFollowType
	{
		//CREATE_DATE
		public DateTime? CREATE_DATE {get;set;}

		//关注分组编号
		[Key]
		[MaxLength(36)]
		public String TYPE_ID {get;set;}

		//分组名
		[MaxLength(50)]
		public String TYPE_NAME {get;set;}

		//所属用户
		[MaxLength(36)]
		public String USER_ID {get;set;}

	}
}

