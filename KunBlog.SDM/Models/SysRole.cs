using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	public class SysRole
	{
		//角色编号
		[Key]
		[MaxLength(36)]
		public String ROLE_ID {get;set;}

		//角色名称
		[MaxLength(50)]
		public String ROLE_NAME {get;set;}

	}
}

