using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	public class SysPurviewRole
	{
		//PURVIEW_ID
		[Key]
		[MaxLength(36)]
		public String PURVIEW_ID {get;set;}

		//ROLE_ID
		[Key]
		[MaxLength(36)]
		public String ROLE_ID {get;set;}

	}
}

