using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KunBlog.SDM.Models
{
	/// <summary>
	/// 角色权限表
	/// </summary>
	public class SysPurviewRole
	{
		//PURVIEW_ID
		[Key, Column(Order = 1)]
		[MaxLength(36)]
		public String PURVIEW_ID {get;set;}

		//ROLE_ID
		[Key, Column(Order = 2)]
		[MaxLength(36)]
		public String ROLE_ID {get;set;}

	}
}

