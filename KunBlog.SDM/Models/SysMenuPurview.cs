using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KunBlog.SDM.Models
{
	/// <summary>
	/// 菜单权限表
	/// </summary>
	public class SysMenuPurview
	{
		//MENU_ID
		[Key, Column(Order = 1)]
		[MaxLength(36)]
		public String MENU_ID {get;set;}

		//PURVIEW_ID
		[Key, Column(Order = 2)]
		[MaxLength(36)]
		public String PURVIEW_ID {get;set;}

	}
}

