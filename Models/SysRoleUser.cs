using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace KunBlog.SDM.Models
{
	public class SysRoleUser
	{
		//ROLE_ID
		[Key, Column(Order = 2)]
		[MaxLength(36)]
		public String ROLE_ID {get;set;}

		//USER_ID
		[Key, Column(Order = 1)]
		[MaxLength(36)]
		public String USER_ID {get;set;}

	}
}

