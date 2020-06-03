using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	public class SysMenu
	{
		//CREATE_BY
		[MaxLength(36)]
		public String CREATE_BY {get;set;}

		//CREATE_DATE
		public DateTime? CREATE_DATE {get;set;}

		//菜单编号
		[Key]
		[MaxLength(36)]
		public String MENU_ID {get;set;}

		//菜单图标
		[MaxLength(100)]
		public String MENU_IMG {get;set;}

		//菜单名称
		[MaxLength(50)]
		public String MENU_NAME {get;set;}

		//父菜单
		[MaxLength(36)]
		public String MENU_PARENT {get;set;}

		//菜单路径
		[MaxLength(100)]
		public String MENU_PATH {get;set;}

		//菜单类型
		[MaxLength(50)]
		public String MENU_TYPE {get;set;}

		//UPDATE_BY
		[MaxLength(36)]
		public String UPDATE_BY {get;set;}

		//UPDATE_DATE
		public DateTime? UPDATE_DATE {get;set;}

	}
}

