using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	public class SysRoleUser
	{
		//ROLE_ID
		[Key]
		[MaxLength(36)]
		public String ROLE_ID {get;set;}

		//USER_ID
		[Key]
		[MaxLength(36)]
		public String USER_ID {get;set;}

	}
}

