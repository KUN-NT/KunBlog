using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	public class SysMenuPurview
	{
		//MENU_ID
		[Key]
		[MaxLength(36)]
		public String MENU_ID {get;set;}

		//PURVIEW_ID
		[Key]
		[MaxLength(36)]
		public String PURVIEW_ID {get;set;}

	}
}

