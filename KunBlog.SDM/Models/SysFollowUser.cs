using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	public class SysFollowUser
	{
		//CREATE_DATE
		public DateTime? CREATE_DATE {get;set;}

		//TYPE_ID
		[Key]
		[MaxLength(36)]
		public String TYPE_ID {get;set;}

		//USER_ID
		[Key]
		[MaxLength(36)]
		public String USER_ID {get;set;}

	}
}

