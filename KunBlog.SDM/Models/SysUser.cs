using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	/// <summary>
	/// 用户表
	/// </summary>
	public class SysUser
	{
		//CREATE_BY
		[MaxLength(36)]
		public String CREATE_BY {get;set;}

		//CREATION_DATE
		public DateTime? CREATION_DATE {get;set;}

		//EF_CHAR1
		[MaxLength(100)]
		public String EF_CHAR1 {get;set;}

		//EF_CHAR2
		[MaxLength(100)]
		public String EF_CHAR2 {get;set;}

		//是否删除
		[MaxLength(1)]
		public String IS_DEL {get;set;}

		//UPDATE_BY
		[MaxLength(36)]
		public String UPDATE_BY {get;set;}

		//UPDATE_DATE
		public DateTime? UPDATE_DATE {get;set;}

		//用户描述
		[MaxLength(100)]
		public String USER_DESC {get;set;}

		//用户编号
		[Key]
		[MaxLength(36)]
		public String USER_ID {get;set;}

		//用户头像
		[MaxLength(100)]
		public String USER_IMG {get;set;}

		//用户名称
		[MaxLength(50)]
		public String USER_NAME {get;set;}

		//用户密码
		[MaxLength(50)]
		public String USER_PASSWORD {get;set;}

	}
}

