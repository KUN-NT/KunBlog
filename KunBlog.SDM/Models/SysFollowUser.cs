using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KunBlog.SDM.Models
{
	/// <summary>
	/// 关注人员分类表
	/// </summary>
	public class SysFollowUser
	{
		//CREATE_DATE
		public DateTime? CREATE_DATE {get;set;}

		//TYPE_ID
		[Key, Column(Order = 1)]
		[MaxLength(36)]
		public String TYPE_ID {get;set;}

		//USER_ID
		[Key, Column(Order = 2)]
		[MaxLength(36)]
		public String USER_ID {get;set;}

	}
}

